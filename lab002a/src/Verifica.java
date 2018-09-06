/**
 * 
 *Verifica. Verifíque con un programa si son cierta las siguientes identidades, donde a, b y
c son las longitudes de los lados de un triángulo. A, B y C son los ángulos opuestos a los
lados respectivamente:
 * 
 * @author Marco Antonio Vino
 * @version 1.0 14/03/2018
 * 
 */
public class Verifica {
	public static void main(String[] args) {
		// Varaibles
		double a,b,c, A,B,C,aux,aux2, aux3;
		// Entrada 
		a = 15;
		b=15;
		c=15;
		A = 60;
		B=60;
		C=60;
		// Proceso
		aux= Math.sin(A)/a ;
		aux2 = Math.sin(B)/b ;
		aux3 = Math.sin(C)/c ;
		if (Math.abs(aux - aux2) > 0.000001 || Math.abs(aux3-aux2)> 0.000001 )
			System.out.println("La Propiedad A no se cumple");
		else { System.out.println("La propiedad A se cumple");}
		
		aux = Math.pow(a, 2) + Math.pow(b,2) - 2*a*b*Math.cos(C);
		aux2 = Math.pow(c,2);
		if (Math.abs(aux - aux2) > 0.000001 )
			System.out.println("La Propiedad B no se cumple");
		else { System.out.println("La propiedad B se cumple");}
		
		aux = (a+b)/(a-b);
		aux2 = Math.tan((A+B)/2)/Math.tan((A-B)/2);
		if (Math.abs(aux - aux2) > 0.000001 )
			System.out.println("La Propiedad C no se cumple");
		else { System.out.println("La propiedad C se cumple");}
		

	}

}
