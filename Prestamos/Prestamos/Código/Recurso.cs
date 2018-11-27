/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 11:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace Prestamos
{
	/// <summary>
	/// Description of Recurso.
	/// </summary>
	public class Recurso
	{
		private int codR;
		private string nombre;
		private bool estado; 
		private int CIprest;
		// true para prestado, false para disponible
		public Recurso(int c, string n )
		{
			codR = c;
			nombre = n; 
			estado = false;
			CIprest = 0;
		}
		
		public Recurso(){}
		
		public void prestarR()
		{
			estado = false;
		}
		
		public void writeArch(BinaryWriter escritor)
		{
			escritor.Write(codR);
			escritor.Write(nombre);
			escritor.Write(estado);
			escritor.Write(CIprest);
		}
			
		public void readArch(BinaryReader lector)
		{
			codR = lector.ReadInt32();
			nombre = lector.ReadString();
			estado = lector.ReadBoolean();
			CIprest = lector.ReadInt32();
		}
		
		public int getCodR(){return codR;}
		public string getNombreR(){return nombre;}
		public bool getEstadoR(){return estado;}
		public void setEstado(bool x){estado = x;}
		public int getCiPrest(){return CIprest;}
		public void setCiPrest(int x){CIprest = x;}
		~Recurso(){}
	}
}
