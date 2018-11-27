/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 12:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab121_06_01
{
	/// <summary>
	/// Description of Calle.
	/// </summary>
	public class Calle<T> : ObraPublica<T>
	{
		private string nombre;

		public Calle(string cal, string nom, string gest) : base(nom, gest)
		{
			nombre = cal;
			nroMat =0;
		}

		
		public void mostrar()
		{
			Console.WriteLine(nombre);
			for (int i = 0 ; i<nroMat;i++)
			{
				A[i].mostrar();
			}
		}
		
		public void estCobrY(T X, string nom )
		{
			if(Nombre.Equals(nom))
			{
				Console.WriteLine(nom);
				matEstX(X);
			}
		}
		
		
		~Calle(){}
	}
}
