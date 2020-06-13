using System.Threading.Tasks;
using BelleMata.Entities;
using BelleMata.Models.RequestModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BelleMata.Controllers
{
    [Controller]
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserRequestModel model)
        {
            ApplicationUser user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
            };
            await _userManager.CreateAsync(user, model.Password);
            return RedirectToAction("Index", "Home");
        }
    }
}