using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 600;
            product1.UnitInStock = 2;

            Product product2 = new Product { 
                
                Id = 2, 
                CategoryId = 5, 
                ProductName = "Buzdolabı", 
                UnitPrice = 4500, 
                UnitInStock = 7 
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            productManager.Topla2(7,9);

            int sonuc = productManager.Topla(3, 6);
            Console.WriteLine(sonuc * 2);

            // int, double, bool ... değer tip
            // class, interface, abstract ... referans tip

        }
    }
}
