/** 
 * Verifíca. Verifíque con un programa si son cierta las siguientes propiedades de logaritmos
 * 
 * @author Marco Antonio Vino
 * @version 1.0 13/03/2018
 * 
 */
public class VerificaLog {
	public static void main(String[] args) {
		// Varaibles
		double a,b, x,y, aux, aux2; 
		// Entrada 
		a = 10;
		b= 15;
		x=19;
		y=3.2;
		// Proceso
		aux = Math.pow(a, Math.log(x)/Math.log(a));
		if (Math.abs(aux - x) > 0.000001)
			System.out.println("La Propiedad A no se cumple");
		else { System.out.println("La propiedad A se cumple");}
		
		aux = Math.log(Math.pow(a, x))/Math.log(a);
		if (Math.abs(aux - x) > 0.000001)
			System.out.println("La Propiedad B no se cumple");
		else { System.out.println("La propiedad B se cumple");}
		
		aux =  Math.log(x*y)/Math.log(a);
		aux2 = Math.log(x)/Math.log(a) + Math.log(y)/Math.log(a);
		if (Math.abs(aux - aux2) > 0.000001)
			System.out.println("La Propiedad C no se cumple");
		else { System.out.println("La propiedad C se cumple");}
		
		aux =  Math.log(x/y)/Math.log(a);
		aux2 = Math.log(x)/Math.log(a) - Math.log(y)/Math.log(a);
		if (Math.abs(aux - aux2) > 0.000001)
			System.out.println("La Propiedad D no se cumple");
		else { System.out.println("La propiedad D se cumple");}
		
		aux =  Math.log(x)/Math.log(a);
		aux2 = (Math.log(b)/Math.log(a))*(Math.log(x)/Math.log(b));
		if (Math.abs(aux - aux2) > 0.000001)
			System.out.println("La Propiedad E no se cumple");
		else { System.out.println("La propiedad E se cumple");}
	}
}
