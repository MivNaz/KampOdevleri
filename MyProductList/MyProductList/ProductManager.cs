using System;
using System.Collections.Generic;
using System.Text;

namespace MyProductList
{
    public class ProductManager : Product
    {
        public void Listele(List<Product> products, int secim)
        {
            switch (secim)
            {
                case 1:
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine(products[i].ProductId + "-" + products[i].ProductName + "-" + products[i].ProductPrice);
                    }
                    break;
                case 2:
                    foreach (Product item in products)
                    {
                        Console.WriteLine(item.ProductId + " - " + item.ProductName + " - " + item.ProductPrice);
                    }
                    break;
                case 3:
                    int say = 0;
                    while (say < products.Count)
                    {
                        Console.WriteLine(products[say].ProductId + " - " + products[say].ProductName + " - " + products[say].ProductPrice);
                        say++;
                    }
                    break;
            }
        }
    }
}
