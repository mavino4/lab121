using System;
using System.IO;

public class Grupo
{
	private string nombre;
	private string especialidad;
	private int nm;
	private Musico[] integrantes = new Musico[20];
	
	public Grupo()
	{
		nombre = "D-lejía";
		especialidad = "rock";
		for (int i =0 ; i<nm ; i++)
		{
			integrantes[i] = new Musico();
		}
	}
	
	public Grupo(string nom, string esp, int nrom)
	{
		nombre = nom;
		especialidad = esp;
		nm = nrom;
		for (int i = 0 ; i< nm; i++)
		{
			integrantes[i].leer(i);
		}
	}
	
	
	public void leerGrupo()
	{
		Console.Write("Nombre del Grupo --> ");
		nombre = Console.ReadLine();
		Console.Write("Especialidad del grupo --> ");
		especialidad = Console.ReadLine();
		Console.Write("Nro De Integrantes -- > ");
		nm = Int32.Parse(Console.ReadLine());
		for (int i = 0 ; i< nm; i++)
		{
			Musico mi = new Musico();
			mi.leer(i);
			integrantes[i] = mi;
		}
	}
	
	
	public void mostrar()
	{
		Console.WriteLine("\nGrupo: " + nombre);
		Console.WriteLine("Especialidad: " + especialidad);
		Console.WriteLine("Integrantes : ");
		for (int i = 0 ; i< nm; i++)
		{
			integrantes[i].mostrarM();
		}
	}
	
	public void escribirArch(BinaryWriter escritor)
		{
			escritor.Write(nombre);
			escritor.Write(especialidad);
			escritor.Write(nm);
			for (int i = 0 ; i< nm; i++)
			{
				integrantes[i].WriteArch(escritor);
			}
			
		}
	
	public void leerArch(BinaryReader lector)
		
		{
			nombre=lector.ReadString();
			especialidad =lector.ReadString();
			nm = lector.ReadInt32();
			for (int i = 0 ; i< nm ; i++)
			{
				Musico mx = new Musico();
				mx.ReadArch(lector);
				integrantes[i] = mx;
			}
		}
	
	public bool esParte(string X)
	{
		for (int i = 0 ; i< nm ; i++)
			{
			if (integrantes[i].getName().Equals(X))
			{
				return true;
			}
			}
		return false;

		
	}
	
	public string getNombre()
	{
		return nombre;
	}
	
	public string getEsp()
	{
		return especialidad;
	}
	
	~Grupo() {Console.WriteLine("Borrando Memoria");}
}
