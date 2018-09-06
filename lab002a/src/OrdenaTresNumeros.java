
import java.util.Scanner;

/**
 * Leer 3 números e imprimir de manera ascendente
 * 
 * @author Marco Antonio Vino Chipana CI 9111299
 * @version 1.0   14/03/2018
 * 
 */
public class OrdenaTresNumeros {

	public static void main(String[] args) {
		//Variables 
		double a,b,c, aux;
		
		//Entrada 
		Scanner leer = new Scanner(System.in);
		a = leer.nextDouble();
		b = leer.nextDouble();
		c = leer.nextDouble();
		
		// Proceso
		if (a<b) {
			aux = a; 
			a = b;
			b = aux;}
		if(a<c) {
			aux = a;
			a = c; 
			c = aux;}
		//Salida
		if (b < c) {System.out.print(b +"\n" + c +"\n" +a);}
		else { System.out.println(c +"\n" + b +"\n" +a);	}
	}

}
