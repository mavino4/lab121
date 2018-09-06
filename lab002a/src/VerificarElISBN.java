import java.util.Scanner;

/**
 * Un ISBN-10 (Número de libro estándar internacional) consta
de 10 dígitos: d1,d2,d3,d4,d5,d6,d7,d8,d9,d10. El último dígito, d10, es una suma de comprobación, que se calcula a partir de los otros nueve dígitos
Si la suma de comprobación es 10, el último dígito se denota como X de acuerdo con la
convención ISBN-10. Escriba un programa que solicite al usuario ingresar los primeros 9
dígitos y muestre el ISBN de 10 dígitos (incluidos los ceros a la izquierda). Su programa
debe leer la entrada como un entero.
 * 
 * @author Marco Antonio Vino
 * @version 1.0 14/03/2018
 * 
 */
public class VerificarElISBN {
	public static void main(String[] args) {
		// Varaibles
		int entrada, d1,d2,d3,d4,d5,d6,d7,d8,d9,d10; 
		Scanner lee = new Scanner(System.in);
		// Entrada 
		System.out.print("Ingrese los primeros 9 dígitos de un ISBN como número entero:");
		entrada = lee.nextInt();
		// Proceso
		d9 = entrada%10;
		d8 = (entrada/10)%10;
		d7 = (entrada/100)%10;
		d6 = (entrada/1000)%10;
		d5 = (entrada/10000)%10;
		d4 = (entrada/100000)%10;
		d3 = (entrada/1000000)%10;
		d2 = (entrada/10000000)%10;
		d1 = Math.floorDiv(entrada, 100000000);
		d10 = (d1*1 + d2*2 + d3*3+ d4*4 +d5*5 + d6*6 + d7*7+ d8*8 +d9*9)%11; 
		// Salida
		if (d10 == 10)
			System.out.print("El número ISBN-10 es " +d1+d2+d3+d4+d5+d6+d7+d8+d9+"X");
		else
			System.out.print("El número ISBN-10 es " +d1+d2+d3+d4+d5+d6+d7+d8+d9+d10);
		
	}

}
