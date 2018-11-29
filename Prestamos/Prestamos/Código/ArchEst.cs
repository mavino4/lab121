﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Prestamos
{
	public class ArchEst
	{
		private string nombre;
	    private string route;
		public ArchEst( string na ) {
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
		public void addE(Estudiante Ei) {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archE = File.Open(route + nombre, FileMode.Append);
			BinaryWriter escritor = new BinaryWriter(archE);
			try {
					Ei.writeArch(escritor);
			}
			catch( Exception ) {
				Console.WriteLine("Fallo en adicionar el objeto !!!");
			}
			finally {
				archE.Close();
			}
		}
		
		public LinkedList<Estudiante> listar() {
			// Abrimos el archivo o se crea un nuevo archivo si no existe
			Stream archE = File.Open(route+nombre, FileMode.Open);
			BinaryReader lector = new BinaryReader(archE);
	        var EstList= new LinkedList<Estudiante> {};
	        try
	        {
			
				while( true ) {
	                var Ei= new Estudiante();
	                Ei.readArch(lector);
	                EstList.AddLast(Ei);
				}
			}
			catch( Exception ) {
				Console.WriteLine("Fin de archivo ...");
			}
			finally {
				archE.Close();
			}
	        return EstList;
		}

	    
	    public Estudiante getEstudante(int ci)
	    {
	        Stream archE = File.Open(route + nombre, FileMode.Open);
	        BinaryReader lector = new BinaryReader(archE);
	        try
	        {
	            while (true)
	            {
	                var Ei = new Estudiante();
	                Ei.readArch(lector);
	                if (Ei.getCI() == ci) {
	                    archE.Close();
	                    return Ei;
	                }
	            }
	        }
	        catch (Exception)
	        {
	            Console.WriteLine("Fin de archivo ...");
	        }
	        finally
	        {
	            archE.Close();
	        }
	        return null;
	    }
	
	
	    public bool eliminar( int codigo ) {
			bool sw = false;
			try {
				// Abrimos el archivo o se crea un nuevo archivo si no existe
				Stream archp = File.Open(route + nombre, FileMode.Open);
				Stream archTemporal = File.Open(route+"temp.dat", FileMode.OpenOrCreate);
				BinaryReader lector = new BinaryReader(archp);
				BinaryWriter escribeTemp = new BinaryWriter(archTemporal);
				Estudiante Ei = new Estudiante();
				
				try {
					while( true ) {
						Ei.readArch(lector);
						if( Ei.getCI() != codigo ) {
							Ei.writeArch(escribeTemp);
						}
						else {
							sw = true;
						}
					}
				}
				catch( Exception ) {
					// No hace nada.
				}
				finally {
					archp.Close();
					archTemporal.Close();
					File.Replace(route+"temp.dat",route+nombre,nombre + ".bak");
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
 