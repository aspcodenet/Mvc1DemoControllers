using System.Collections.Generic;

namespace Mvc1DemoControllers.ViewModels
{
    public class SupplierIndexViewModel
    {
        public List<SupplierViewModel> Suppliers { get; set; } = new List<SupplierViewModel>();
    }

    public class SupplierViewModel
    {
        public int Id { get; set; }
        public string Namn { get; set; }
    }


    public class SupplierEditViewModel
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string Stad { get; set; }
    }


}