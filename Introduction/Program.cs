using System;
using System.Collections.Generic;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Suma a doua nr.
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c= a + b;
            Console.WriteLine("Suma celor doua nr {0} si {1} este {2}", a,b,c);*/

            //Read from a keyboard n numbers, until the number ends in two 0s. Store the numbers and then display each of them

            Console.WriteLine("Introdu numere");
            int n= int.Parse(Console.ReadLine());
            List<int> numar = new List<int>();
            numar.Add(n);


            while(n%100 != 0)
            {
                n = int.Parse(Console.ReadLine());
                numar.Add(n);
            }


            Console.WriteLine(string.Join(", ", numar));

            Console.ReadKey();
        }
    }
}
