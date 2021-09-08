using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInyection
{
    public class ProductStockRepositoryService : IProductStockRepositoryService
    {
        //el diccionario se guarda el indice(Product) y el valor (int)
        public static Dictionary<Product, int> _productStockDatabase = Setup();
        private static Dictionary<Product, int> Setup()
        {
            var productStockDatabase = new Dictionary<Product, int>();
            productStockDatabase.Add(Product.Keyboard, 1);
            productStockDatabase.Add(Product.Mic, 1);
            productStockDatabase.Add(Product.Mouse, 1);
            productStockDatabase.Add(Product.Speaker, 1);
            return productStockDatabase;
        }
        //acceso al diccionario
        public bool IsInStock(Product product)
        {
            Console.WriteLine("Call get on database");
            return _productStockDatabase[product] > 0;
        }

        public void ReduceStock(Product product)
        {
            Console.WriteLine("Call get on database");
            _productStockDatabase[product]--;
        }
        public void AddStock(Product product)
        {
            Console.WriteLine("Call get on database");
            _productStockDatabase[product]++;
        }

    }
}
