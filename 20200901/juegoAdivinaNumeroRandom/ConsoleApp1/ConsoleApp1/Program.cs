using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto, respuesta, maxIntentos = 3;
            Random random = new Random();
            numeroSecreto = random.Next(10);

            string mensaje = "";
            Console.WriteLine("Intenta adivinar el numero secreto \n");

            for (int i = 0; i < maxIntentos; i++)
            {
                respuesta = int.Parse(Console.ReadLine());
                mensaje = respuesta == numeroSecreto ? "Has Ganado" : "El numero no es correcto. Vuelve a intentar";
                if(respuesta == numeroSecreto)
                {
                    break;
                }


                if (i == maxIntentos - 1)
                {
                    mensaje = "Has perdido el numero era: " + numeroSecreto;
                    break;
                } 
                
                Console.WriteLine(mensaje + "\n");
            }

            Console.WriteLine(mensaje + "\n");
        }
    }
}
