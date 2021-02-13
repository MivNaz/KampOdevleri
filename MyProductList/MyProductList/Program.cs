using System;
using System.Collections.Generic;

namespace MyProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> stok = new List<Product>();
            Product product1 = (new Product { ProductId = 1, ProductName = "Kalem", ProductPrice = 11 });
            Product product2 = (new Product { ProductId = 2, ProductName = "Ataç ", ProductPrice = 12 });
            Product product3 = (new Product { ProductId = 3, ProductName = "Zımba", ProductPrice = 18 });
            Product product4 = (new Product { ProductId = 4, ProductName = "Silgi", ProductPrice = 5 });

            ProductManager productManager = new ProductManager();
            productManager.ProductId = 5;
            productManager.ProductName = "Kalemtıraş";
            productManager.ProductPrice = 8;

            ProductManager productManager1 = new ProductManager
            {
                ProductId = 6,
                ProductName = "Defter",
                ProductPrice = 20
            };

            ProductManager productManager2 = new ProductManager
            {
                ProductId = 7,
                ProductName = "Dolma  Kalem",
                ProductPrice = 15
            };

            //Ürünlerin Listeye Eklenmesi
            stok.Add(product1);
            stok.Add(product2);
            stok.Add(product3);
            stok.Add(product4);
            stok.Add(productManager);
            stok.Add(productManager1);
            stok.Add(productManager2);

            Console.WriteLine("-STOKTAKİ ÜRÜNLER-");
            Console.WriteLine("-------------------------");
            productManager.Listele(stok, 1); //For döngüdü ile ekleme.
            Console.WriteLine("-------------------------");
            productManager.Listele(stok, 2); //Foreach döngüsü ile ekleme
            Console.WriteLine("-------------------------");
            productManager.Listele(stok, 3); //While döngüsü ile ekleme
        }
    }
}
