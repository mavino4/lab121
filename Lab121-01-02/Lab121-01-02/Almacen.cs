using System;

namespace Lab121_01_02
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Almacen
	{
		private String nombre;
		private int nroP;
		private string[,] Prod = new string[3,100];
		
		// a) Instanciar objetos almacén con constructor por defecto, por parámetros y método leer y mostrar.
		public Almacen()
		{
			nombre = "Doña Martha";
			nroP = 2;
			Prod[1,1] = "Pan";
			Prod[2,1] = "48";
			Prod[3,1] = "0.5";
		}
		
		public Almacen(string name, int n)
		{	
			string namei, canti, pi;
			nombre = name;
			nroP = n;
			for (int i = 1; i <= nroP; i++)
			{	
			// leyendo las carateristicas de cada producto
				Console.WriteLine("Ingrese el nombre del producto #" + i);
				namei = Console.ReadLine();
				Console.WriteLine("Ingrese la cantidad de " + namei);
				canti = Console.ReadLine();
				Console.WriteLine("Ingrese el precio de " + namei);
				pi = Console.ReadLine();
				Prod[1,i] = namei;
				Prod[2,i] = canti;
				Prod[3,i] = pi;
			}
		}
		// b) Buscar al producto con X e incrementar la cantidad en Y.
		public void deltaY_X(string X, int Y)
		{
			for (int i=1; i<= nroP; i++)
			{
				if (Prod[1,i] == X)
				{
					Prod[2,i] = ""+(int.Parse(Prod[2,i]) + Y);
					break; // Consideraremos que los nombres de los productos son únicos 
				}
			}
		}
		// c) Mostrar los productos con precio mayor a X.
		public void piGthanX(int X)
		{
			for (int i=1; i<= nroP; i++)
			{
				if (int.Parse(Prod[3,i]) > X)
				{
					Console.WriteLine(Prod[1,i] + " a Bs. " + Prod[3,i]);
				}
			}
		}
		
		// d) Eliminar los productos con cantidad 0.
		public void delete0()
		{	int lastReview = 1;
			bool change;
			while (true)
			{	change = false;
				for (int i=lastReview; i<= nroP; i++)
				{
					if (int.Parse(Prod[2,i]) == 0)
					{
						Prod[1,i] = Prod[1,nroP];
						Prod[2,i] = Prod[2,nroP];
						Prod[3,i] = Prod[3,nroP];
						nroP--;
						lastReview = i;
						change = true;
						break;
					}
				}	
				if (!change)
				{
					break;
				}
			}
		}
		
		// e) Ordenar los productos por nombre.
		
		
		// f) Hay un objeto clientes, y otro objeto venta, realizar la venta de productos al cliente.
		
		~Almacen() 
		{
			Console.WriteLine("Borrando Memoria");
		}
	}
}
