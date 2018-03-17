//confirmed by gogata258
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 mile == 1.60934 kilometers
            double miles = int.Parse(Console.ReadLine());
            double kilometres = (miles * 1.60934);
            Console.WriteLine($"{kilometres:F2}");

        }
    }
}
