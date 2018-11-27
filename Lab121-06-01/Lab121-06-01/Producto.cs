/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 26/11/2018
 * Time: 11:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lab121_06_01
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		protected double precio;
		
		public Producto(){precio =0;}
		public Producto(double p) { precio = p;}
		public double getPrecio(){return precio;}
		~Producto(){}
	}
}
