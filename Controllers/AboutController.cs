using Microsoft.AspNetCore.Mvc;

namespace Sheets_Styles.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
