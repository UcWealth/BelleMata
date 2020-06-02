using BelleMata.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace BelleMata.Controllers
{
    [Controller]
    public class AccountsController : Controller
    {
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(CreateUserRequestModel model)
        {
            return View();
        }
    }
}