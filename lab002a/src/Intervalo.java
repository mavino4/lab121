import java.util.Scanner;

/**
 * Intervalo. Escriba un programa que lea dos hora e imprima el número de horas
 * y minutos entre estas 2 horas.  
 * 
 * @author Marco Antonio Vino Chipana CI 9111299
 * @version 1.0   13/03/2018
 */
public class Intervalo {
	public static void main(String[] args) {
		// Varaibles
		Scanner lee = new Scanner(System.in);
		double H1, H2, hd, md ,h1, m1, h2,m2;
		// Entrada
		System.out.print("Inntroduzca h1 y m1: ");
		h1 = lee.nextInt();
		m1 = lee.nextInt();
		System.out.print("Inntroduzca h2 y m2: ");
		h2 = lee.nextInt();
		m2 = lee.nextInt();
		// Proceso
		H1 = h1 + m1/60;
		H2 = h2 + m2/60;
		hd = (int) Math.abs(H1-H2); 
		md = ((Math.abs(H1-H2)%1)*60);
		// Salida
		System.out.println((int) hd + " hora(s) y "+ (int) md + " minuto(s)" );

	}

}
