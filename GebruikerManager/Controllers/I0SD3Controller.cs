using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GebruikerManager.Controllers
{
    [Authorize(Roles = "I0SD3")]
    public class I0SD3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
