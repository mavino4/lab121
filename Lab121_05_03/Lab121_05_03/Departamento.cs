using System;

public class Departamento : BienInmueble
{
	private double superficie;
	
	public Departamento()
	{
		superficie = 0;
		
	}
	
	public Departamento(double p, double sup)
	{
		setPrecio(p);
		superficie = sup;
		
	}
	
	public void leeDepto()
	{
		Console.Write("El precio del departamento es de --> ");
		setPrecio(Double.Parse(Console.ReadLine()));
		Console.Write("La superficie del departamento (m2) es de --> ");
		superficie = Double.Parse(Console.ReadLine());
	}
	
	~Departamento(){Console.WriteLine("Delete");}
}

