using System;
using System.IO;
class ArchPlato
{
   private string nombre;
   
   public ArchPlato(string na)
   {
   	nombre=na;
   }
   
   public void crearNuevo()
   {
   	if (System.IO.File.Exists(nombre))
   	    {
   	    	Console.WriteLine("Realmente quiere crear el archivo. Ojo se borraran los registros? s/n");
   	    	if (Console.ReadKey().KeyChar=='s')
   	    		System.IO.File.Delete(nombre);
   	    
   	    }
   	    else
   	    	Console.WriteLine("el archivo no existe");
   }
   
   
   public void adicionar()
   {
    	Stream arch=File.Open(nombre,FileMode.Append);
    	BinaryWriter escribe=new BinaryWriter(arch);
    	Plato pi=new Plato();
    	try
    	{
    		do
    		{
    			Console.WriteLine();
    			pi.leer();
                pi.escribirArch(escribe);
    			Console.Write("Desea seguir añadiendo? s/n");
    		}while(Console.ReadKey().KeyChar=='s');
      }
    	catch(Exception )
    	{
    		Console.WriteLine("Fallo en adicionar el objeto!!");
    	}
    	finally
    	{
    		arch.Close();
    	}
  	}
   public void listar()
   {
   	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector=new BinaryReader(arch);
   	Plato pi=new Plato();
   	try
   	{
   		Console.WriteLine("\nDatos del Platos");
   		Console.WriteLine("====================");
   			
   		while(true)
   		{
   			pi.leerArch(lector);
   			Console.WriteLine("\n");
   			pi.mostrar();
   		}
   	}
   	catch(Exception)
   	{
   		Console.WriteLine("Fin de archivo...");
   	}
   	finally{
   		arch.Close();
   	}
   }
   
   
   public void PlatosIngX( string X)
   {
   	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector=new BinaryReader(arch);
   	Plato pi=new Plato();
   	try
   	{
   		Console.WriteLine("\nPlatos con " + X);
   		Console.WriteLine("====================");
   			
   		while(true)
   		{
   			pi.leerArch(lector);
   			if (pi.ingX(X))
   			{
   				Console.WriteLine(pi.getPlato());
   			}
   		}
   	}
   	catch(Exception)
   	{
   		Console.WriteLine("Fin de archivo...");
   	}
   	finally{
   		arch.Close();
   	}
   }
   
   public void platosMasCaros()
   {
   	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector=new BinaryReader(arch);
   	Plato pi=new Plato();
   	double caro = 0;
   	try
   	{

   		while(true)
   		{
   			pi.leerArch(lector);
   			if (pi.getCosto()> caro)
   			{
   				caro = pi.getCosto();
   			}
   		}
   	}
   	catch {
   		Console.WriteLine();
   	}
   	
   	arch.Close();
   	arch = File.Open(nombre,FileMode.OpenOrCreate);
   	lector =new BinaryReader(arch);
   	Plato pi2=new Plato();
   	try
   	{

   		while(true)
   		{
   			pi2.leerArch(lector);
   			if ( caro - pi2.getCosto() < 0.00000001)
   			{
   				pi2.mostrar();
   			}
   		}
   	}
   	catch {Console.WriteLine();}

   	finally{
   		arch.Close();
   	}
   	
   	
   }
   
   
   public bool DelIngXPlatY( string X, string Y)
   {	bool sw = false;
		try {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open(@"C:\Users\Marco\Documents\LAB121\Temp.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Plato pi = new Plato();
			try {
				while( true ) {
					pi.leerArch(lector);
					if( pi.getPlato().Equals(Y)) {
						pi.deleteIngX(X);
						sw = true;
					}
					pi.escribirArch(escribeTemp);
				}
			}
			catch( Exception ) {
				// No hace nada.
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace(@"C:\Users\Marco\Documents\LAB121\Temp.dat", nombre, nombre+".bak");
			}
		}
		catch( Exception ) {
			Console.WriteLine("El archivo no se puede acceder !!!");
		}
		return sw;
	}

 
   public bool AddIngXPlatY( string X, string Y)
   {	bool sw = false;
		try {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archp = File.Open(nombre, FileMode.OpenOrCreate);
			Stream archTemporal = File.Open(@"C:\Users\Marco\Documents\LAB121\Temp.dat", FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(archp);
			BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
			Plato pi = new Plato();
			try {
				while( true ) {
					pi.leerArch(lector);
					if( pi.getPlato().Equals(Y)) {
						pi.AddIngX(X);
						sw = true;
					}
					pi.escribirArch(escribeTemp);
				}
			}
			catch( Exception ) {
				// No hace nada.
			}
			finally {
				archp.Close();
				archTemporal.Close();
				File.Replace(@"C:\Users\Marco\Documents\LAB121\Temp.dat", nombre, nombre+".bak");
			}
		}
		catch( Exception ) {
			Console.WriteLine("El archivo no se puede acceder !!!");
		}
		return sw;
	}
   
   
}
