import java.util.Scanner;

/**
 * Ciencia: día de la semana. La congruencia de Zeller es un algoritmo desarrollado por
Christian Zeller para calcular el día de la semana.
a) h es el día de la semana (0: sábado, 1: domingo, 2: lunes, 3: martes, 4: miércoles, 5:
jueves, 6: viernes).
b) q es el día del mes.
c) m es el mes (3: marzo, 4: abril, ..., 12: diciembre). Enero y febrero se cuentan como
los meses 13 y 14 del a~no anterior.
d) j es el siglo (es decir,año/100)
e) k es el año del siglo (es decir, año %100).
Tenga en cuenta que la división en la fórmula realiza una división entera. Escriba un
programa que solicite al usuario ingresar un año, mes y día del mes, y muestre el nombre
del día de la semana.
 * 
 * @author Marco Antonio Vino
 * @version 1.0 14/03/2018
 * 
 */
public class DiaDeLaSemana {
	public static void main(String[] args) {
		// Varaibles
		int year, m, q , result;
		Scanner lee = new Scanner(System.in);
		// Entrada 
		System.out.print("Ingrese el añoo: (por ejemplo, 2012): ");
		year = lee.nextInt();
		System.out.print("Ingrese el mes: 1-12: ");
		m = lee.nextInt();
		System.out.print("Ingrese el día del mes: 1-31: ");
		q = lee.nextInt();
		// Proceso
		switch (m) {
		case 1:
			m = 13; 
			year -=1;
			break;
		case 2:
			m = 14;
			year -=1;
			break;
		case 13: case 14:
			m = 99;
			break;
		}
		int j = year/100;
		int k = year%100;
		result = (q + (int)((26*(m+1))/10) + k + (int) (k/4) + (int) (j/4) +5*j)%7 ;
		// Salida
		if (q>31 || q<1 || m<3 || m>14 || year<0 || (m==14 && q>=30)) {
			System.out.println("Error , fecha no válida");
		}
		else {
		switch (result) {
		case 0: 
			System.out.println("El día de la semana es sábado");
			break;
		case 1: 
			System.out.println("El día de la semana es domingo ");
			break;
		case 2: 
			System.out.println("El día de la semana es lunes");
			break;
		case 3: 
			System.out.println("El día de la semana es martes");
			break;
		case 4: 
			System.out.println("El día de la semana es miércoles");
			break;
		case 5: 
			System.out.println("El día de la semana es jueves");
			break;
		case 6: 
			System.out.println("El día de la semana es viernes");
			break;
		}
		}	
	}

}
