/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 05/09/2018
 * Time: 10:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab121_01_01
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Corriendo el Main
			Fecha A = new Fecha();
			A.mostrar();
			A.adiDias(15);
			A.mostrar();
			A.adiSem(7);
			A.mostrar();
			Fecha B = new Fecha(1,12,1998);
			B.mostrar();
			A.deltaDays(B);
			if(A.sonIguales(B))
			{
				Console.WriteLine("Fechas Iguales");
			}
			else
			{
				Console.WriteLine("Fechas Diferentes");
			}
			
			Console.WriteLine(A.getDay());
			Console.WriteLine(A.getMonth());
			Console.WriteLine(A.getYear());
			
			Console.WriteLine(A.toString());
			
			
			Console.ReadKey(true);
			
		}
	}
}