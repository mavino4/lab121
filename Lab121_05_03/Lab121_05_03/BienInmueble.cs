using System;

public class BienInmueble
{
	protected double precio;
	
	public BienInmueble()
	{
		precio = 0;
	}
	
	public BienInmueble(double p)
	{
		precio = p;
	}
	
	public double getPrecio() {return precio;}
	public void setPrecio(double X) {precio = X;}
	~BienInmueble(){Console.WriteLine("Liberando Memoria");}
}

