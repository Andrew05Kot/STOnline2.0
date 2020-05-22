//using Microsoft.AspNetCore.Mvc;
//using STOnline.BLL.DTOs;
//using STOnline.BLL.Interfaces.IServices;
//using STOnline.DAL.DBContext;
//using STOnline.DAL.Models.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using System.Security.Claims;
//using Microsoft.AspNetCore.Identity;
//using STOnline.DAL.Models;

//namespace STOnline.WEB.Controllers
//{
//    public class AccountControler : ControllerBase
//    {

//        private readonly UserManager<Client> _userManager;
//        private readonly SignInManager<Client> _signInManager;

//        public AccountControler(UserManager<Client> userManager, SignInManager<Client> signInManager)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        [HttpPost]
//        [Route("Registeration")]
//        public async Task<IActionResult> Register(Client model)
//        {
//            try
//            {
//                // добавляем пользователя
//                var result = await _userManager.CreateAsync(model);
//                if (result.Succeeded)
//                {
//                    // установка куки
//                    await _signInManager.SignInAsync(model, false);
//                    //return RedirectToAction("Index", "Home");
//                }
//                else
//                {
//                    foreach (var error in result.Errors)
//                    {
//                        ModelState.AddModelError(string.Empty, error.Description);
//                    }
//                }
//                return StatusCode(400);
//            } catch
//            {
//                return StatusCode(403);
//            }
//        }


//        //private ApplicationContext _context;
//        //private IClientService _clientService;
//        //public AccountControler(ApplicationContext context, IClientService clientService)
//        //{
//        //    _context = context;
//        //    _clientService = clientService;
//        //}

//        //[Route("Registeration")]
//        //[HttpPost]
//        //public async Task<IActionResult> Registeration([FromBody]ClientDTO client)
//        //{
//        //    client.RoleId = 2;
//        //    //client.Role.Name = "user";


//        //    //try
//        //    //{
//        //        await _clientService.AddClient(client);
//        //        await Authenticate(client);
//        //        return Ok();
//        //        //try
//        //        //{
//        //        //    await Authenticate(client);
//        //        //}
//        //        //catch
//        //        //{
//        //        //    return StatusCode(403);
//        //        //}
//        //    //    return StatusCode(201);
//        //    //}
//        //    //catch
//        //    //{
//        //    //    return StatusCode(400);
//        //    //}

//        //}
//        //private async Task Authenticate(ClientDTO client)
//        //{
//        //    // создаем один claim
//        //    var claims = new List<Claim>
//        //    {
//        //        new Claim(ClaimsIdentity.DefaultNameClaimType, client.ClientEmail),
//        //        new Claim(ClaimsIdentity.DefaultRoleClaimType, client.Role?.Name)
//        //    };
//        //    // создаем объект ClaimsIdentity
//        //    ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
//        //        ClaimsIdentity.DefaultRoleClaimType);
//        //    // установка аутентификационных куки
//        //    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
//        //}
//    }
//}
