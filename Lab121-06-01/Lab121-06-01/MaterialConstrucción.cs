/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 26/11/2018
 * Time: 11:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab121_06_01
{
	/// <summary>
	/// Description of MaterialConstrucción.
	/// </summary>
	public class MaterialConstrucción<T>:Producto
	{
		private string nombre;
		private T estado;
		
		public MaterialConstrucción()
		{
			nombre ="";
		}
		
		public MaterialConstrucción(string n, T e)
		{
			nombre =n ;
			estado = e;
		}
		
		public void mostrar()
		{
			Console.WriteLine(nombre, estado);
		}
		
		public T getEstado(){return estado;}
		public string getNombre(){return nombre;}
		~MaterialConstrucción(){}
	}
}
