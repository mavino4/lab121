using System;

namespace Lab121_06_02
{
	/// <summary>
	/// Description of PremioOscar.
	/// </summary>
	public class PremioOscar<W,T,Z>
	{
		private int año;
		private int nroPeliculas;
		private string[] Peliculas = new string[30];
		private Valoracion<W,T,Z>[] Vals = new Valoracion<W, T, Z>[30];
		
		public PremioOscar()
		{
		}
	}
}
