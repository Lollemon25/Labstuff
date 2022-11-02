using System;

namespace Lab2Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Introdu un nr:");
            int nr = Convert.ToInt32(Console.ReadLine());
            //string binary = Convert.ToString(nr, 2);

            string binary = "";

            while(nr > 0)
            {
                binary = (nr % 2) + binary;
                nr = nr/2;
            }

            Console.WriteLine("");
            Console.Write("Binary:");
            Console.WriteLine(binary);*/

            double res = 0;
            Console.Write("Introdu primul nr:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introdu operatia(+,-,*,/):");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introdu al doilea nr:");
            double b = Convert.ToDouble(Console.ReadLine());

            switch(c)
            {
                case '+': 
                    res = a + b; break;
                case '-': 
                    res = a - b; break;
                case '*': 
                    res = a * b; break;
                case '/': 
                    res = a / b; break;
                default: Console.WriteLine("Not an operator!!!"); break;
            }

            Console.WriteLine("");
            Console.WriteLine("Rezultatul operatiei {0}{1}{2} = {3}", a,c,b,res);
            
            Console.ReadKey();
        }
    }
}
