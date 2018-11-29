using System;
using System.IO;

namespace Prestamos
{
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
