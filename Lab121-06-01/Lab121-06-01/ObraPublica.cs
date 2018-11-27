/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 12:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab121_06_01
{
	/// <summary>
	/// Description of ObraPublica.
	/// </summary>
	public class ObraPublica<T>
	{
		protected string Nombre;
		protected string gestion;
		protected  int nroMat;
		protected  MaterialConstrucción<T>[] A = new MaterialConstrucción<T>[30];
		
		
		public ObraPublica()
		{
			Nombre = "";
			gestion = "";
			nroMat =0;
		}
		
		
		public ObraPublica(string nom, string gest)
		{
			Nombre = nom;
			gestion = gest;
			nroMat =0;
		}
		
		
		public void addMat(MaterialConstrucción<T> Mi)
		{
			A[nroMat++] = Mi;
		}
		
		
		public void mostrarObra()
		{
			Console.WriteLine(Nombre, gestion);
			for (int i = 0 ; i<nroMat;i++)
			{
				A[i].mostrar();
			}
		}
		
		
		public void matEstX(T X)
		{
			for (int i =0; i<nroMat ; i++)
			{
				if(A[i].getEstado().Equals(X))
				{
					Console.WriteLine(A[i].getNombre());
				}
			}
		}
		
		~ObraPublica(){}
		
		

	}
}
