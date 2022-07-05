using ErrorHandling.Web.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;

namespace ErrorHandling.Web.Controllers
{
    [CustomHandleExceptionFilterAttribute(ErrorPage = "Error1")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } 
        public IActionResult Index()
        {

            int value1 = 5;
            int value2 = 0;
            int result = value1 / value2;

            return View();
        }

        public IActionResult Privacy()
        {
            throw new FileNotFoundException();
            return View();
        }
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.path = exception.Path;
            ViewBag.message = exception.Error.Message;
            return View();
        }

        public IActionResult Error1()
        {
            return View();
        }
       
    }
}
