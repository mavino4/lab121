using System;
using System.IO;
using System.Collections.Generic;

namespace Prestamos
{
	public class ArchRec
	{
		private string nombre;
	    private string route;
		public ArchRec( string na ) {
			nombre = na;
	        route = "..\\";
	        crearNuevo();
	    }
		
	    /// Metodo que crea un nuevo archivo borrando si existia uno
		/// anterior.
		public void crearNuevo() {
			if( !System.IO.File.Exists(route+nombre) ){
	            File.Create(route + nombre).Close();
	        }
			else
				Console.WriteLine("El archivo no existe.");
		}
		
		/// Adiciona un producto al final del archivo.
		public void addR(Recurso Ri) {
			Stream archR = File.Open(route + nombre, FileMode.Append);
			BinaryWriter escritor = new BinaryWriter(archR);
			try {
					Ri.writeArch(escritor);
			}
			catch( Exception ) {
				Console.WriteLine("Fallo en adicionar el objeto !!!");
			}
			finally {
				archR.Close();
			}
		}
	
		
		
		public LinkedList<Recurso> listar() {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archR = File.Open(route+nombre, FileMode.Open);
			BinaryReader lector = new BinaryReader(archR);
	        var RecList= new LinkedList<Recurso> {};
	        try
	        {
			
				while( true ) {
	                var Ri= new Recurso();
	                Ri.readArch(lector);
	                RecList.AddLast(Ri);
				}
			}
			catch( Exception ) {
				Console.WriteLine("Fin de archivo ...");
			}
			finally {
				archR.Close();
			}
	        return RecList;
		}

	    
	    public Recurso getrecurso(int cod)
	    {
	        Stream archR = File.Open(route + nombre, FileMode.Open);
	        BinaryReader lector = new BinaryReader(archR);
	        try
	        {
	            while (true)
	            {
	                var Ri = new Recurso();
	                Ri.readArch(lector);
	                if (Ri.getCodR() == cod) {
	                    archR.Close();
	                    return Ri;
	                }
	            }
	        }
	        catch (Exception)
	        {
	            Console.WriteLine("Fin de archivo ...");
	        }
	        finally
	        {
	            archR.Close();
	        }
	        return null;
	    }
	
	
	    public bool eliminar( int codigo ) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(route+nombre, FileMode.Open);
				Stream archTemporal = File.Open(route+"temp.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Recurso Ei = new Recurso();
				
				try {
					while( true ) {
						Ei.readArch(lector);
						if( Ei.getCodR() != codigo ) {
							Ei.writeArch(escribeTemp);
						}
						else {
							sw = true;
						}
					}
				}
				catch( Exception ) {
					Console.WriteLine("NoEncontroEl Archivo");
					// No hace nada.
				}
				finally {
					archp.Close();
					archTemporal.Close();
					File.Replace(route+"temp.dat",route+nombre, nombre + ".bak");
				}
			}
			catch( Exception ) {
				Console.WriteLine("El archivo no se puede acceder !!!");
			}
			return sw;
		}

		public string getRoute(){return route + nombre;}
	}
}