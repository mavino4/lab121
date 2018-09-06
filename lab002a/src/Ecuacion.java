import java.util.Scanner;

/**
 * Ecuación. Dados los valores de una ecuación cuadrática ax2 + bx + c = 0 hallar sus dos
raíces. Los valores a, b, c se ingresan por teclado y son números enteros. En el caso de
raíces imaginarias imprima el mensaje "no hay soluciónn en los números reales".

 * @author Marco Antonio Vino
 * @version 1.0 14/03/2018
 * 
 */
public class Ecuacion {
	public static void main(String[] args) {
		// Varaibles
		double a, b ,c ,aux, x1 , x2;
		Scanner lee = new Scanner(System.in);
		// Entrada 
		a = lee.nextDouble();
		b = lee.nextDouble();
		c = lee.nextDouble();
		// Proceso
		aux = Math.pow(b,2) - 4*a*c;
		if (aux<0) {
			System.out.println("No hay solución en los números reales");
		}
		else {
			x1 = (-b + Math.sqrt(aux))/2*a;
			x2 = (-b - Math.sqrt(aux))/2*a;
		// Salida
			System.out.println("X1 =" + x1);
			System.out.println("X2 =" + x2);
		}

	}

}
