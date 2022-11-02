using System;

namespace LabMilesperhr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introdu distanta(metri):");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introdu timpul(ore):");
            double hr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introdu timpul(min):");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Introdu timpul(sec):");
            double sec = Convert.ToDouble(Console.ReadLine());

            double timeSec = (hr * 3600) + (min * 60) + sec;
            double mPerSec = distance / timeSec;
            double kmPerHr = (distance / 1000) / (timeSec / 3600);
            double milPerHr = kmPerHr * 0.621;
            Console.WriteLine(" ");
            Console.WriteLine("m/sec:{0}",mPerSec);
            Console.WriteLine("km/h:{0}",kmPerHr);
            Console.WriteLine("miles/h:{0},",milPerHr);
        }
    }
}
