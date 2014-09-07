using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Confabulum.Controllers
{
    public class WatchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string deck, string show)
        {
            return View();
        }
    }
}
