using System;

namespace _01_Debit_card
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());
            int int4 = int.Parse(Console.ReadLine());

            Console.Write("{0:d4} ", int1);
            Console.Write("{0:d4} ", int2);
            Console.Write("{0:d4} ", int3);
            Console.Write("{0:d4} ", int4);
        }
    }
}