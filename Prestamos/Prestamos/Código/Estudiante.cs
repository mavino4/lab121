using System;
using System.IO;

namespace Prestamos
{
	public class Estudiante
	{
		private int CI;
		private string nombre;
		private int np =0;
		private int[] Prestados = new int[100];
		
		public Estudiante()
		{ np =0;
		}
		
		public Estudiante( int ci, string n)
		{
			CI= ci;
			nombre = n;
		}
		
		public void writeArch(BinaryWriter escritor)
		{
			escritor.Write(CI);
			escritor.Write(nombre);
			escritor.Write(np);
			for (int i =0 ; i<np; i++)
			{
				escritor.Write(Prestados[i]);
			}
		}
		
		
		public void readArch(BinaryReader lector)
		{
			CI = lector.ReadInt32();
			nombre = lector.ReadString();
			np = lector.ReadInt32();
			for (int i =0 ; i<np; i++)
			{
				Prestados[i] = lector.ReadInt32();
			}
		}
		
		public void prestarX(int cod)
		{
			Prestados[np++] = cod;
		}
		
		public bool devolverX(int cod)
		{
			for (int i=0 ; i < np; i++)
			{
				if (Prestados[i] == cod)
				{
					Prestados[i] = Prestados[np--];
					return true;
				}
			}
			return false;
		}
		
		public int getCI(){return CI;}
		public string getNombre(){return nombre;}
		~Estudiante(){}
	}
}
