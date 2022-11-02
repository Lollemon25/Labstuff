using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu un sir de caractere");
            string cuvant = Console.ReadLine();
            int litera = 0;
            int nr = 0;
            int caracter = 0;

            foreach(char ch in cuvant)
            {
                if (ch >= '0' && ch <= '9')
                {
                    nr++;
                }
                else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                {
                    litera++;
                }
                else
                {
                    caracter++;
                }
            }

            Console.WriteLine("Number of alphabets is:{0}", litera);
            Console.WriteLine("Number of digits is:{0}", nr);
            Console.WriteLine("Number of char is:{0}", caracter);

        }
    }
}
