using System;
using System.IO;

public class Musico
{
	private string nombre;
	private string instrumento;
	
	public Musico()
	{
		nombre = "";
		instrumento = "";
	}
	
	public void leer(int i)
	{	
		Console.WriteLine("Integrante " + (i+1));
		Console.Write("Nombre: ");
		nombre = Console.ReadLine();
		Console.Write("Instrumento: ");
		instrumento = Console.ReadLine();
	}
	
	public void WriteArch(BinaryWriter escritor)
	{
		escritor.Write(nombre);
		escritor.Write(instrumento);
	}
	
	public void ReadArch(BinaryReader lector)	
	{
		nombre=lector.ReadString();
		instrumento =lector.ReadString();
	}
	
	
	public Musico(string name, string inst)
	{
		nombre = name;
		instrumento = inst;
	}
	
	public void setNombre(string a)
	{
		nombre = a;
	}
	
	public void setInst(string b)
	{
		instrumento = b;
	}
	
	public string getName()
	{
		return nombre;
	}
	
	public string getInst()
	{
		return instrumento;
	}
	
	public void mostrarM()
	{
		Console.WriteLine(nombre + "\t" + instrumento);
	}
	
	~Musico()
	{
		Console.WriteLine("Borrando memoria");
	}
}
