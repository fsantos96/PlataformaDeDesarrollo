using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                numero = solicitarNumero("Ingrese el numero");
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste el numero era " + secreto);
            }
        }

        static int solicitarNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }
    }
}
