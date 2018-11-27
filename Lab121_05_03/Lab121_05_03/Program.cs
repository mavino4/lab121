using System;

namespace Lab121_05_03
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Departamento A = new Departamento();
			Departamento B = new Departamento(34.234, 234.234);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}