using System;

namespace Lab121_06_02
{
	public class Valoracion<W,T,Z>
	{
		private int nroJurados;
		private string[] Jurados = new string[30];
		private W[] ValMusica = new W[30];
		private T[] ValActuacion= new T[30];
		private Z[] ValArgumentos = new Z[30];
		
		
		public Valoracion()
		{
			nroJurados =0; 
		}
		
		public Valoracion(string[] Jug, W[] VM, T[] VAc, Z[] VAr)
		{
			nroJurados = Jug.Length;
			Jurados = Jug;
			ValMusica = VM;
			ValActuacion = VAc;
			ValArgumentos = VAr;
		}
		
		
		
		
		
		~Valoracion(){}
	}
}
