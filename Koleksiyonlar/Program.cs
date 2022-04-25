using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            isimler = new string[5];
            isimler[4] = "Emre";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            Console.WriteLine("-----------------");
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("Emre");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(isimler2[0]);
        }
    }
}
