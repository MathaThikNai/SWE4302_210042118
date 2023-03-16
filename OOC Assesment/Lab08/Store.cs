using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Store
    {
        public Store() { }

        public List<Product> products = new List<Product>();
        private Manager _manager { get; set; }
        public SalesAssociate _saler { get; set; }

        public void showStoreDetails()
        {
            Console.WriteLine($"Manager : {_manager._name}" +
                $"SalesAssociate : {_saler._name}"+
                $"Products : {products.Count}");
        }
    }
}
