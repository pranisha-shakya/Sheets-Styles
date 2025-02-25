using Microsoft.AspNetCore.Mvc;

namespace Sheets_Styles.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
