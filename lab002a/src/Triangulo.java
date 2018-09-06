/**
 *
 * Escriba un programa que realice los cálculos sobre un triángulo,
 * x1, y1 
 * x2, y2 
 * x3, y3
 * El trabajo consiste en calcular las siguientes propiedades del triángulo:
 * Las longitudes de sus 3 lados
 * Los ángulos de las 3 esquinas
 * El perímetro
 * El área 
 * 
 * @author Marco Antonio Vino Chipana CI 9111299
 * @version 1.0   13/03/2018
 * 
 */
import java.util.Scanner;
public class Triangulo{
	public static void main(String[] args) {
		// Varaibles
		// puntos iniciales
		double x1,x2,x3,y1,y2,y3; 
		//lados del triángulo
		double A,B,C; 
		// Variables extra
		double S , Area, Perimetro,a1, a2, a3;
		
		// Entrada
		Scanner leer = new Scanner(System.in);
		x1 = leer.nextDouble();
		y1 = leer.nextDouble();
		x2 = leer.nextDouble();
		y2 = leer.nextDouble();
		x3 = leer.nextDouble();
		y3 = leer.nextDouble();
		
		// Proceso
		A = Math.sqrt(Math.pow((x2-x1), 2) + Math.pow((y2-y1), 2));
		B = Math.sqrt(Math.pow((x3-x1), 2) + Math.pow((y3-y1), 2));
		C = Math.sqrt(Math.pow((x3 - x2), 2) + Math.pow((y3 - y2), 2));
		S = (A+B+C)/2;
		a1 = Math.toDegrees(Math.acos((Math.pow(A, 2) + Math.pow(B, 2)-Math.pow(C, 2))/(2*B*A)));
		a2 = Math.toDegrees(Math.acos((Math.pow(A, 2) + Math.pow(C, 2)-Math.pow(B, 2))/(2*A*C)));
		a3 = Math.toDegrees(Math.acos((Math.pow(B, 2) + Math.pow(C, 2)-Math.pow(A, 2))/(2*B*C)));
		Area = Math.sqrt(S*(S-A)*(S-B)*(S-C));
		Perimetro = A+B+C;
		
		// Salida
		System.out.println("El lado A mide : " + A);
		System.out.println("El lado B mide : " + B);
		System.out.println("El lado C mide : " + C);
		System.out.printf("El ángulo alpha es : %.2f grados \n",a1);
		System.out.printf("El ángulo beta es : %.2f grados \n" ,a2);
		System.out.printf("El ángulo gamma es : %.2f grados \n" , a3);
		System.out.println("El perímetro del triángulo es: " + Perimetro);
		System.out.println("El área del triángulo es: " + Area);
	}
}
