using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Core.Entities.Concrete;
using MultiShop.Entities.DTOs;

namespace MultiShop.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is null) return View();

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, request.Password, false, false);
            if(result.Succeeded)
                return RedirectToAction("Index", "Home");

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is not null)
                return View();

            User newUser = new()
            {
                UserName = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                ImageUrl = "avatar",
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, request.Password);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
    }
}
