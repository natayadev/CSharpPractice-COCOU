using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que permita el ingreso de 2 fechas y muestre los resultados:
            - Muestre ambas fechas en la pantalla en formato legible (Lunes, 17 de mayo de 20…)
            - Días de diferencia entre ambas fechas
            - Semanas de diferencia entre ambas fechas */
            //Inserta días
			Console.WriteLine("Inserte una fecha de inicio en formato dd-mm-aa: "); 
			DateTime Fecha1 = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Inserte fecha final en formato dd-mm-aa: "); 
			DateTime Fecha2 = DateTime.Parse(Console.ReadLine());
			Console.WriteLine(" ");

			//Formato de fechas ingresadas
            Console.WriteLine("La fecha de inicio ingresada es: ");
            Console.WriteLine(Fecha1.ToString("dddd dd MMMM, yyyy"));
            Console.WriteLine(" ");

            Console.WriteLine("La fecha final ingresada es: ");
			Console.WriteLine(Fecha2.ToString("dddd dd MMMM, yyyy"));
            Console.WriteLine(" ");

            //Calcula la diferencia entre fechas
			TimeSpan dif = Fecha2 - Fecha1;
			int DifDias = dif.Days;
			
			//Muestra la diferencia entre días
			Console.WriteLine("Días de diferencia: {0} ", DifDias);
            
            //Muestra la diferencia de semanas
            int DifSem = DifDias / 7;
            Console.WriteLine("Semanas de diferencia: {0} ", DifSem);
        }
    }
}