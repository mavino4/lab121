using System;
    class Program {
        static void Main( string[] args ) {
            bool sw = true;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            while( sw ) {
                Console.WriteLine("\n                                      ");
                Console.WriteLine("          MENU                          ");
                Console.WriteLine("     ARCHIVO GRUPOS                    ");
                Console.WriteLine("     ===============                    ");
                Console.WriteLine("                                        ");
                Console.WriteLine("1. CREAR ArchGRUPO 1                       ");
                Console.WriteLine("2. ADICIONAR ArchGRUPO 1                   ");
                Console.WriteLine("3. LISTADO ArchGRUPO 1                             ");
                Console.WriteLine("4. Mostrar grupo del integrante X     ");
                Console.WriteLine("5. Nro del genero X                    ");
                Console.WriteLine("6. CREAR ArchGRUPO 2                       ");
                Console.WriteLine("7. ADICIONAR ArchGRUPO 2                   ");
                Console.WriteLine("8. LISTADO ArchGRUPO 2                           ");
				Console.WriteLine("9. Comparar grupos de 2 archivos               ");
                Console.WriteLine("0. SALIR                                ");
                
                Console.Write("INTRODUSCA  UNA  OPCION             =>  ");
                ArchGrupo AG1= new ArchGrupo(@"C:\Users\Marco\Documents\LAB121\AG1.dat");
                ArchGrupo AG2= new ArchGrupo(@"C:\Users\Marco\Documents\LAB121\AG2.dat");
     
                switch( Console.ReadKey().KeyChar ) {
                    case '1':
                        AG1.crearNuevo();
                        break;
                    case '2':
                        Console.Write("\nAdicionando al 1er archivo");
                        AG1.adicionar();
                        break;
                    case '3':
                        Console.Write("\n********************Archivo 1*****************\n");
                        AG1.listar();
                        break;
                    case '4':
                        //...
                        Console.Write("\nIngrese el integrante a buscar -->");
                        string x = Console.ReadLine();
                        AG1.gruposDeX(x);
                        break;
                    case '5':
                        //...
                        Console.Write("\nIngrese el genero a buscar -->");
                        string X = Console.ReadLine();
                        AG1.NDeTipoX(X);
                        break;
                        
                    case '6':
                        AG2.crearNuevo();
                        break;
                    case '7':
                        Console.Write("\nAdicionando al 1er archivo");
                        AG2.adicionar();
                        break;
                    case '8':
                        Console.Write("\n********************Archivo 2*****************\n");
                        AG2.listar();
                        break;
                        
                    case '9':
                        AG1.gruposIguales(AG2);
                        break;
                        
                    default:
                        Console.WriteLine("\n   El programa ya termino  !!!");
                        Console.Beep();
                        sw = false;
                        break;
                }
            }
   
            
    }
}
