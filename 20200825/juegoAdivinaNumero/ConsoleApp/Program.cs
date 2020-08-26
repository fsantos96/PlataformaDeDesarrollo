using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto = 7, respuesta;
            string mensaje ="";
            Console.WriteLine("Intenta adivinar el numero secreto \n");

            do
            {
                respuesta = int.Parse(Console.ReadLine());
                mensaje = respuesta == numeroSecreto ? "Has Ganado" : "El numero no es correcto. Vuelve a intentar";
                Console.WriteLine(mensaje + "\n");
            }
            while (respuesta != numeroSecreto);
        }
    }
}
