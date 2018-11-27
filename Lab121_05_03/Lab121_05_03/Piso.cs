using System;

public class Piso
{
	private int nro;
	private int nroDep;
	Departamento[] Pi = new Departamento[10];
	
	public Piso()
	{ nro = 0;
		nroDep = 0;
	}
	
	public void leeP()
	{
		Console.Write("Número de piso -- > ");
		nro = Int32.Parse(Console.ReadLine());
		Console.Write("Número de departamentos-- > ");
		nroDep = Int32.Parse(Console.ReadLine());
		for (int i=0 ; i<nroDep ; i++)
		{
			Departamento Di = new Departamento();
			Di.leeDepto();
			Pi[i] = Di;
		}
		
	}
	
	
	~Piso(){Console.WriteLine("Borrando memoria");}
}

