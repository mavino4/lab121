import java.util.Scanner;

/**
 * Logaritmo. Escriba un programa java que lea la base b (entero) y el número x (real).
Imprima el resultado del logb x. Valide si x es negativo:
Ejemplo de entrada
base = 2
x = 0.5
Ejemplo de salida
-1
 * 
 * @author Marco Antonio Vino
 * @version 1.0 14/03/2018
 * 
 */
public class Logaritmo {
	public static void main(String[] args) {
		// Varaibles
		double base, X, result;
		Scanner lee = new Scanner(System.in);
		// Entrada 
		System.out.print("base: ");
		base = lee.nextDouble();
		System.out.print("x: ");
		X = lee.nextDouble();
		// Proceso
		if (X<=0 || base<=0) {
		//Salida
			System.out.println("ERROR valores no válidos");
		}
		else {
			result=Math.log(X)/Math.log(base);
			System.out.println(result);
		}
		
	}

}
