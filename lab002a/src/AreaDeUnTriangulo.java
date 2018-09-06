import java.util.Scanner;

/**
 * Escriba un diagrama que solicite ingresar 3 puntos del tipo
 * x1, y1 
 * x2, y2 
 * x3, y3
 * de un triángulo e imprima su área
 * 
 * @author Marco Antonio Vino Chipana CI 9111299
 * @version 1.0   14/03/2018
 * 
 */
public class AreaDeUnTriangulo {
	public static void main(String[] args) {
		// Varaibles
		// puntos iniciales
		double x1,x2,x3,y1,y2,y3; 
		//lados del triángulo
		double A,B,C; 
		// Variables extra
		double S , Area;
		
		// Entrada
		Scanner leer = new Scanner(System.in);
		x1 = leer.nextDouble();
		y1 = leer.nextDouble();
		x2 = leer.nextDouble();
		y2 = leer.nextDouble();
		x3 = leer.nextDouble();
		y3 = leer.nextDouble();
		
		// Proceso
		A = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 -y1, 2));
		B = Math.sqrt(Math.pow(x3- x1, 2) + Math.pow(y3-y1, 2));
		C = Math.sqrt(Math.pow(x3- x2, 2) + Math.pow(y3-y2, 2));
		S = (A+B+C)/2;
		Area = Math.sqrt(S*(S-A)*(S-B)*(S-C));
		
		// Salida
		System.out.printf("El área del triángulo es: %.2f", Area);
	}
}
