using ErrorHandling.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandling.Web.Controllers
{
    [CustomHandleExceptionFilterAttribute(ErrorPage = "Error2")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            throw new Exception("Veri tabanında bir hata meydana geldi");
            return View();
        }
        public IActionResult Error2()
        {
            return View();
        }
    }
}
