using System;
using System.IO;

public class ArchGrupo
{
	private string nombre;

   public ArchGrupo(string na)
   {
   	nombre=na;
   }
   
   public void crearNuevo()
   {
   	if (System.IO.File.Exists(nombre))
   	    {
   	    	Console.WriteLine("Realmente quiere crear el archivo. Ojo se borraran los registros? s/n");
   	    	if (Console.ReadKey().KeyChar=='s')
   	    	{
   	    		System.IO.File.Delete(nombre);
   	    	}
   	    
   	    }
   	else
   	{
		Console.WriteLine("el archivo no existe");
   	}
   	    
   }
   
   
   
   public void adicionar()
   {
    	Stream arch=File.Open(nombre,FileMode.Append);
    	BinaryWriter escribe=new BinaryWriter(arch);
    	Grupo Gi=new Grupo();
    	try
    	{
    		do
    		{
    			Console.WriteLine();
    			Gi.leerGrupo();
    			Console.WriteLine("Grupo leido");
                Gi.escribirArch(escribe);
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
   	Grupo Gi=new Grupo();
   	try
   	{
   		Console.WriteLine("\nListado de grupos");
   		Console.WriteLine("====================");
   			
   		while(true)
   		{
   			Gi.leerArch(lector);
   			Gi.mostrar();
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

	public void gruposDeX(string X)
   {
   	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector=new BinaryReader(arch);
   	Grupo Gi=new Grupo();
   	try
   	{
   		Console.WriteLine("\nLa persona " + X + " esta en los siguientes grupos:\n");
   		while(true)
   		{
   			Gi.leerArch(lector);
   			if(Gi.esParte(X))
   			{
   				Console.WriteLine(Gi.getNombre());
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


public void NDeTipoX(string X)
   {
   	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector=new BinaryReader(arch);
   	Grupo Gi=new Grupo();
   	int C =0;
   	try
   	{
   		while(true)
   		{
   			Gi.leerArch(lector);
   			if(Gi.getEsp().Equals(X))
   			{
   				C++;
   			}
   		}
   	}
   	catch(Exception)
   	{
   		Console.WriteLine("Fin de archivo...");
   	}
   	finally{
   		arch.Close();
   		Console.WriteLine("\nExisten " + C + " grupos del genero " + X + "\n");
   		
   	}
   }
   
public void gruposIguales(ArchGrupo G2)
{
	Console.WriteLine("\nLista de coincidencias");
   	Stream arch1=File.Open(nombre,FileMode.OpenOrCreate);
   	BinaryReader lector1=new BinaryReader(arch1);
   	Grupo Gi=new Grupo();
   	try
   	{
   		while(true)
   		{
   			Gi.leerArch(lector1);
   			{
   				
   					Stream arch2=File.Open(G2.nombre,FileMode.OpenOrCreate);
				   	BinaryReader lector2=new BinaryReader(arch2);
				   	Grupo Gr=new Grupo();
				   	try
				   	{
				   		while(true)
				   		{
				   			Gr.leerArch(lector2);
				   			if(Gi.getNombre().Equals(Gr.getNombre()))
				   			{
				   				Console.WriteLine(Gi.getNombre());
				   				break;
				   			}
				   		}
				   	}
				   	finally{
				   		arch2.Close();
				   	}
   			}
   		}
   	}
   	catch(Exception)
   	{
   		Console.WriteLine("Fin de archivo...");
   	}
   	finally{
   		arch1.Close();
   	}
	
}
	
}