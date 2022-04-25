﻿using System;

namespace OOP1
{

    class Program
    {
        static void Main(string[] args)
        {
            //  int, double, bool --> değer tipi
            //  dizi, class, abstract class, interface... --> referans tipi

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product() { Id = 2, CategoryId = 5, ProductName = "Sandalye", UnitPrice = 300, UnitsInStock = 8 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            Console.WriteLine(product1.UnitPrice);
        }
    }
}
