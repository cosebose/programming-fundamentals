using System;

namespace SUApp1
{
	class Program
	{
		enum Mammals { dog };
		enum Reptile { crocodile, tortoise, snake };
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			if (Enum.IsDefined(typeof(Mammals), input)) Console.WriteLine("mammal");
			else if (Enum.IsDefined(typeof(Reptile), input)) Console.WriteLine("reptile");
			else Console.WriteLine("unknown");
		}
	}
}