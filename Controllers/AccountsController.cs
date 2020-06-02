using BelleMata.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace BelleMata.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register(CreateUserRequestModel model)
        {
            return View();
        }
    }
}