using System;
using System.Collections.Generic;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita la carga de apuestas de ruleta.
            Se pueden ingresar tantos números (entre 0 y 36) como se desee.
            Se podrá indicar la finalización de la carga de las apuestas 
            cargando un valor fuera del rango permitido.
            Al finalizar la carga, el programa deberá efectuar una tirada 
            aleatoria en la que se obtenga un número de la ruleta, 
            siendo que cada número tiene la misma probabilidad de ser elegido.
            Se deberá informar:
            Cuantos ganadores hubo
            Cuantos perdedores hubo*/

            //Inserta apuesta
            Console.WriteLine("JUEGO DE APUESTAS");
            Console.WriteLine("Inserte su apuesta: ");
            List<string> Apuesta = new List<string>();
            Apuesta.Add(Console.ReadLine());

            //Define opciones
            Console.WriteLine("¿Desea seguir apostando?: ");
            string Rta;
            Rta = Console.ReadLine();

            if (Rta == "si")
            {
                return;
            }
            else (Rta == "no")
            {
                Console.WriteLine("Los ganadores son: ");
                Console.WriteLine("Los perdedores son: ");
            }

        }
    }
}
