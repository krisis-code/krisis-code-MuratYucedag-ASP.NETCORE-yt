using Microsoft.AspNetCore.Mvc;

namespace muratyucedag.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
