using System;

namespace ejercicio_mascota
{
    class Program
    {
        static void Main(string[] args)
        {
            var mascota = "mascota";

            var accion = new Accion(new Dormir());
            Console.Write(accion.Dormir(mascota));
            
            var accion = new Accion(new Banar());
            Console.Write(accion.Banar(mascota));
            
            var accion = new Accion(new Jugar());
            Console.Write(accion.Jugar(mascota));
            
            var accion = new Accion(new Comer());
            Console.Write(accion.Comer(mascota));

            var accion = new Accion(new Derpertar());
            Console.Write(accion.Despertar(mascota));
        }
    }
}
