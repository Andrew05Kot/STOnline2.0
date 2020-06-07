using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using STOnline.DAL.Models.Entities;
using STOnline.WEB.ViewModels;

namespace STOnline.WEB.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        //private readonly AplicationSettings _appSettings;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager/*, IOptions<AplicationSettings> appSetings*/)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //_appSettings = appSetings.Value;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<Object> postUser(UserModel model)
        {
            var user = new User()
            {
                UserName = model.UserName,
                Email = model.Email
            };
            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                return Ok(result);
            } catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("12345678987654321")), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescription);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "Email or password is incorrect." });
            }
        }

        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

    }
}