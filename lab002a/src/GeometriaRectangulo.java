import java.util.Scanner;

/**
 * Geometría: >Apunté a un rectángulo? Escriba un programa que solicite al usuario ingresar
un punto (x, y) y verífique si el punto está dentro del rectángulo centrado en (0, 0) con
ancho 10 y alto 5. Por ejemplo , (2, 2) está dentro del rectángulo y (6, 4) está fuera del
rectángulo,
 * @author Marco Antonio Vino
 * @version 1.0 13/03/2018
 * 
 */
public class GeometriaRectangulo {

	public static void main(String[] args) {
		// Varaibles
		double x1, y1;
		Scanner lee = new Scanner(System.in);
		
		// Entrada 
		System.out.println("Ingrese un punto con dos coordenadas: ");
		x1 = lee.nextDouble();
		y1 = lee.nextDouble();
		// Proceso
		if (Math.abs(x1)<5 && Math.abs(y1)<2.5) {
		// Salida
			System.out.println("El punto (" + x1 +","+y1+") está dentro del rectángulo.");
		}
		else {System.out.println("El punto (" + x1 +","+y1+") no está dentro del rectángulo.");}
	
	}

}
