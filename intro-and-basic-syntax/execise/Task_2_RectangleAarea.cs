using System;

namespace SUApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int.TryParse(Console.ReadLine(), out int Height);
			int.TryParse(Console.ReadLine(), out int Width);
			Console.WriteLine( Height * Width);
		}
	}
}
