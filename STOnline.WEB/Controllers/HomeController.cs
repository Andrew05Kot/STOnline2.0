//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace STOnline.WEB.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly UserManager<IdentityUser> _userManager;
//        private readonly SignInManager<IdentityUser> _singInManager;
//        public HomeController(
//            UserManager<IdentityUser> userManager,
//            SignInManager<IdentityUser> singInManager)
//        {
//            _userManager = userManager;
//            _singInManager = singInManager;
//        }

//        [Route("LogIn")]
//        [HttpPost]
//        public async Task LogIn(string username, string password)
//        {
//            var user = await _userManager.FindByNameAsync(username);
//            if(user != null)
//            {
//                //sing in
//                var singInResult = await _singInManager.PasswordSignInAsync(user, password, false, false);
//                if (singInResult.Succeeded)
//                {
//                    await _singInManager.PasswordSignInAsync(user, password, false, false);
//                }
//            }
//        }

//        [Route("Registration1")]
//        [HttpPost]
//        public async Task RegisterAsync(string username, string password)
//        {
//            var user = new IdentityUser
//            {
//                UserName = username,
//                Email = "",
//            };
//            await _userManager.CreateAsync(user, password);
//            var result = await _userManager.CreateAsync(user, password); 
//            if (result.Succeeded)
//            {

//            }
//        }

//        [Route("LogOut")]
//        public async Task LogOut()
//        {
//            await _singInManager.SignOutAsync();

//        }

//    }
//}
