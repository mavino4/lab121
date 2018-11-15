using System;

class Program {
    static void Main( string[] args ) {
        bool sw = true;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Magenta;
        while( sw ) {
            Console.WriteLine("\n                                      ");
            Console.WriteLine("          MENU                          ");
            Console.WriteLine("     ARCHIVO Platos                    ");
            Console.WriteLine("     ===============                    ");
            Console.WriteLine("                                        ");
            Console.WriteLine("1. CREAR ArchPLatos                        ");
            Console.WriteLine("2. ADICIONAR Plato");
            Console.WriteLine("3. LISTADO Platos                      ");
            Console.WriteLine("4. Platos más costosos                 ");
            Console.WriteLine("5. Platos con el ingrediente X         ");
            Console.WriteLine("6. Borrar ingrediente X del plato Y    ");
            Console.WriteLine("7. Agregar ingrediente X al plato Y    ");
            Console.WriteLine("                                        ");
            Console.Write("INTRODUSCA  UNA  OPCION             =>  ");
            ArchPlato AP1= new ArchPlato(@"C:\Users\Marco\Documents\LAB121\AP1.dat");
            switch( Console.ReadKey().KeyChar ) {
                case '1':
                    AP1.crearNuevo();
                    break;
                case '2':
                    Console.Write("\nAdicionando al 1er archivo");
                    AP1.adicionar();
                    break;
                case '3':
                    Console.Write("\n********************Archivo 1*****************\n");
                    AP1.listar();
                    break;
                case '4':
                    //...
                    AP1.platosMasCaros();
                    break;
                case '5':
                    //...
                    Console.WriteLine("\nIngrese el ingrediente -->: ");
                    string X = Console.ReadLine();
                    AP1.PlatosIngX(X);
                    break;
                    
                case '6':
                    Console.WriteLine("\nIngrese el ingrediente que quiere eliminar -->: ");
                    X = Console.ReadLine();
                    Console.WriteLine("\nIngrese el plato del que quiere eliminarlo -->: ");
                    string Y = Console.ReadLine();                    
                    AP1.DelIngXPlatY(X,Y);
                    break;
                    
                
                case '7':
                    Console.WriteLine("\nIngrese el ingrediente que quiere adicionar -->: ");
                    X = Console.ReadLine();
                    Console.WriteLine("\nIngrese el plato del que quiere adicionarlo -->: ");
                    Y = Console.ReadLine();                    
                    AP1.AddIngXPlatY(X,Y);
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
