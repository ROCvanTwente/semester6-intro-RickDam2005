using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GebruikerManager.Controllers
{
    [Authorize(Roles = "I0SD1")]
    public class I0SD1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
