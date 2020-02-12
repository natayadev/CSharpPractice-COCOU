using System;
using System.Collections.Generic;
using System.Linq;


namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado un valor numérico entero m, 
            determinar e imprimir un listado con los m primeros 
            múltiplos de 3 que no sean múltiplos de 5*/

            //Ingresa el valor
            Console.WriteLine("Ingrese un numero entero m: ");
            int m;
            m = int.Parse(Console.ReadLine());
            
            //Calcula los multiplos y los agrega a las listas
            List<int> Lista1 = new List<int>();
            List<int> Lista2 = new List<int>();

            for (int i = 0; i <= m; i++)
        
                if (i % 3 == 0)
                {
                    Lista1.Add(i);
                }

            for (int j = 0; j <= m; j++)
    
                if (j % 5 == 0)
                {
                    Lista2.Add(j);
                }
            
            //Imprime el listado final
            var ListaFinal = Lista1.Except(Lista2);
            Console.WriteLine("Los multiplos de 3, pero no de 5 son: ");
            Console.WriteLine(ListaFinal.Take(m));

        }
    }
}