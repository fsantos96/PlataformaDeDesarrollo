using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, numero = 0;
            string mensaje;
            Console.WriteLine("Debe ingresar 10 numeros, el ingreso se detendra si la suma de los numero supera los 50");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese su numero");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                if (suma >= 50)
                {
                    break;
                }
            }
                      
            mensaje = suma > 50 ? "El numero supera los 50" : "El resultado de la suma es " + suma;

            Console.WriteLine(mensaje);
            Console.ReadLine();
        }
    }
}
