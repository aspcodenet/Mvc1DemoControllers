using System.Collections.Generic;
using System.Linq;

namespace Mvc1DemoControllers.Models
{
    public interface ISupplierRepository
    {
        List<Supplier> GetAll();
        Supplier Get(int id);
    }

    class SupplierRepository : ISupplierRepository
    {
        private static List<Supplier> all = new List<Supplier>
        {
            new Supplier {City="London", Id =1, Name = "Exotic Liquids"},
            new Supplier {City="Tokyo", Id =3, Name = "Tokyo Traders"},
            new Supplier {City="Göteborg", Id =9, Name = "PB Knäckebröd AB"}
        };
        public List<Supplier> GetAll()
        {
            return all;
        }

        public Supplier Get(int id)
        {
            return all.First(r => r.Id == id);
        }
    }
}