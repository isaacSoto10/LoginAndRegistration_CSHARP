using Microsoft.AspNetCore.Mvc; 
using SimpleLoginRegistration.Models; 
namespace SimpleLoginRegistration.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            return View("Index"); 
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Register(RegUser user)
        {
            if(ModelState.IsValid)
            {
                return View("Success");

            }
            else{
                return View("Index"); 
            }
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(LogUser user)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Index"); 
            }
        }
    }
}