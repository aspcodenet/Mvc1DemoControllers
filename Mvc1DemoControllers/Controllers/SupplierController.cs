using Microsoft.AspNetCore.Mvc;
using Mvc1DemoControllers.Models;
using Mvc1DemoControllers.ViewModels;

namespace Mvc1DemoControllers.Controllers
{
    //Supplier
    //Supplier/Index
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        // GET
        
        public IActionResult Index()
        {
            //Hämta data för aktuell context
            var allSuppliers = _supplierRepository.GetAll();
            
            //knåda data
            var viewModel = new ViewModels.SupplierIndexViewModel();
            foreach (var databasSupplier in allSuppliers)
            {
                var vm = new SupplierViewModel();
                vm.Id = databasSupplier.Id;
                vm.Namn = databasSupplier.Name;
                viewModel.Suppliers.Add(vm);
            }

            return View(viewModel);
        }

        public IActionResult New()
        {
            return View();
        }
        public IActionResult Edit(int Id)
        {
            //Hämta data för aktuell context
            var supplier = _supplierRepository.Get(Id);


            //knåda data + MAPPA
            var viewModel = new ViewModels.SupplierEditViewModel();
            viewModel.Id = supplier.Id;
            viewModel.Namn = supplier.Name;
            viewModel.Stad = supplier.City;


            return View(viewModel);
        }

    }
}