using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Dados dos valores numéricos enteros, calcular e informar su producto mediante sumas sucesivas.*/

            //Inserta números
            Console.WriteLine("Calcular producto entre dos números enteros :)");
            int Num1, Num2, Resultado = 0;
            Console.WriteLine("Inserte un número entero: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte otro número entero: "); 
            Num2 = int.Parse(Console.ReadLine());

            //Calcula el producto
            while (Num2 != 0)
            {
                Resultado = Resultado + Num1;
                Num2 = Num2 - 1;
            }

            //Muestra el resultado
            Console.WriteLine("Su resultado es: {0}", Resultado);
        }
    }
}
