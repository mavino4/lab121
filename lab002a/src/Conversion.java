import java.util.Scanner;

/**
 * Conversión. Escriba un programa para convertir un valor, de una unidad en otra unidad
de distancia. Las unidades se encuentran en m(i)límetros, (c)entímetros, (m)etros y
(k)ilómetros. Lea las dos unidades y luego el valor dado. Ejemplo:
Convertir de: i
Convertir a: c
Valor: 10
10 milímetros = 1 centímetro.
 * 
 * @author Marco Antonio Vino
 * @version 1.0 13/03/2018
 * 
 */
public class Conversion {
	public static void main(String[] args) {
		// Varaibles
		Scanner lee = new Scanner(System.in);
		String umO, umD;
		double valor, conversion =0, verificador=0;
		// Entrada 
		System.out.println("Las unidades se encuentran en m(i)límetros, (c)entímetros, (m)etros o (k)ilómetros");
		System.out.print("Convertir de: ");
		umO = lee.nextLine();
		System.out.print("Convertir a: ");
		umD = lee.nextLine();
		System.out.print("Valor: ");
		valor = lee.nextDouble();
		// Proceso
		switch (umO) {
		case "i" : conversion = valor/1000;
				umO = "milímetros";
				break;
		case "c":  conversion = valor/100;
		umO = "centímetros";
				break;		
		case "m":  conversion = valor;
		umO = "metros";		
		break;
		case "k": conversion = valor*1000;
		umO = "kilometros";		
		break;
		default :
			verificador =1;
			break;
			
		}
		//La variable conversión guardará la entrada en metros
		switch (umD) {
		case "i" : conversion = conversion*1000;
		umD = "milímetros";		
		break;
		case "c":  conversion = conversion*100;
		umD = "centímetros";	
		break;		
		case "m":  
			umD = "metros";	
				break;
		case "k": conversion = conversion/1000;
		umD = "kilometros";	
				break;
		default :
			verificador =1;
			break;
		}
		// Salida
		if (verificador==0)
		System.out.println(valor +" " + umO + " = "+ conversion + " " + umD);
		else { System.out.println("ERROR Unidad de medida no válida");}
	}

}
