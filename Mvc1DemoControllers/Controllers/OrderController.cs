using Microsoft.AspNetCore.Mvc;

namespace Mvc1DemoControllers.Controllers
{
    //Supplier
    //Supplier/Index
    public class OrderController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }
        public IActionResult Edit(int Id)
        {
            //contex.Suppliers-First(r=>r.Id == Id);
            return View();
        }

    }
}