using System;
using System.IO;

public class Plato
{
	private string nombre;
	private double costo;
	private int ni;
	private string[] ingredientes = new string[30];
	
	
	public Plato()
	{
		nombre = "comida";
		costo = 0;
		ni = 0;
	}
	
	public Plato(string name, double c, int n)
	{
		nombre = name;
		costo = c;
		ni = n;
		for (int i = 0 ; i<ni; i++)
		{
			ingredientes[i] = Console.ReadLine();
		}
	}
	
	
	public void leer()
		{
		Console.Write("\nNombre del plato --> ");
		nombre = Console.ReadLine();
		Console.Write("Costo --> ");
		costo = Double.Parse(Console.ReadLine());
		Console.Write("Nro de ingredientes --> ");
		ni = Int32.Parse(Console.ReadLine());
		for (int i = 0 ; i<ni; i++)
		{
			Console.Write("Ingrediente " + (i+1) + "-->");
			ingredientes[i] = Console.ReadLine();
		}
		
		}
		
		public void escribirArch(BinaryWriter escritor)
		{
			escritor.Write(nombre);
			escritor.Write(costo);
			escritor.Write(ni);
			for (int i = 0 ; i<ni; i++)
			{
				escritor.Write(ingredientes[i]);
			}
		}
					
		
		public void leerArch(BinaryReader lector)
		{
			nombre=lector.ReadString();
			costo=lector.ReadDouble();
			ni = lector.ReadInt32();
			for (int i = 0 ; i<ni; i++)
			{
				ingredientes[i] = lector.ReadString();
			}
		}
	
		public void mostrar()
		{
			Console.WriteLine(nombre + "\t" + costo );
			for (int i = 0 ; i<ni; i++)
			{
				Console.WriteLine(ingredientes[i]);
			}

		}
		
		public bool ingX(string X)
		{
			for (int i = 0 ; i<ni; i++)
			{
				if (ingredientes[i].Equals(X))  return true;
			}
			
			return false;	
		}
	
		public void deleteIngX(string X)
		{
			for (int i=0; i<ni; i++)
			{
				if (ingredientes[i].Equals(X))
				{
					ingredientes[i] = ingredientes[ni--];
				}	
			}
		}
		public void AddIngX(string X)
		{
			ingredientes[ni++] = X;
		}
		public string getPlato() {return nombre;}
		public double getCosto() {return costo;}
		public int getNi(){return ni;}
		public string getIngI(int i){return ingredientes[i];}
		
	~Plato(){}
}

