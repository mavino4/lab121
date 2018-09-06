using System;

namespace Lab121_01_01
{
	// Ya que nos se especifica asumiremos que todos los meses tiene 30 días
	// los años 360 días y no consideraremos los años bisiestos.  
	
	public class Fecha
	{
		private int day, month, year;
			
		// 1) Construit una fecha
		public Fecha()
		{
			day = 1 ;
			month = 1;
			year = 1990;
		}
		
		public Fecha(int d, int m, int y)
		{
			day = d; month = m; year= y;
		}
		
		//2) Adicionar días a una fecha
		public void adiDias(int dias)
		{
			day = day + dias;
			if ((day/30.0) > 1)
			{
				month = month + (day/30);
				day = day%30;
			} 
			if ((month/12.0) >1)
			{
				year = year + (month/12);
				month = month%12;
			}
		}
		
		// 3) Adicionar semanas a una fecha 
		public void adiSem(int semanas)
		{
			day = day + semanas*7;
			if ((day/30.0) > 1)
			{
				month = month + (day/30);
				day = day%30;
			} 
			if ((month/12.0) >1)
			{
				year = year + (month/12);
				month = month%12;
			}		
		}
	
		// 4) obtener la cantidad de días entre dos fechas
		public int deltaDays(Fecha A)
		{
			int A1 = day + (month-1)*30 + year*360; // calculando año 1
			int A2 = A.getDay() + (A.getMonth()-1)*30 + A.getYear()*360;
			return Math.Abs(A2-A1);
		}
		
		// 5) comparar si dos fechas son iguales 
		public bool sonIguales(Fecha A)
		{
			if(day == A.getDay() && month==A.getMonth() && year==A.getYear())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// 6) obtener el día de una fecha 
		public int getDay()
		{
			return day;
		}
		
		// 7) obtener el mes de una fecha 
		public int getMonth()
		{
			return month;
		}
		
		// 8) obtener el año de una fecha
		public int getYear()
		{
			return year;
		}		
		// 9) obtener la fecha como cadena
		public string toString()
		{
			return ""+day+"/"+month+"/"+year;
		}
		
		// Mostrando 
		public void mostrar()
		{
			Console.WriteLine("Fecha: "+ toString());
		}
		
		~Fecha()
		{
			Console.WriteLine("Borrando memoria");
		}
	}
}
