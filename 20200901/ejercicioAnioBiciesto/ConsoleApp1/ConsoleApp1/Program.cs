using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = ingresarAnioNacimiento("Ingrese su año de nacimiento");
            string mensaje = "el año ";
            mensaje += esBisiesto(anio) ? "es " : "no es ";
            mensaje += "bisiesto";
            Console.WriteLine(mensaje);
        }

        static int ingresarAnioNacimiento(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        static bool esBisiesto(int anio)
        {
            bool esBisiesto;
            if( anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        esBisiesto = true;
                    } else
                    {
                        esBisiesto = false;
                    }
                } else
                {
                    esBisiesto = true;
                }
            } else
            {
                esBisiesto = false;
            }

            return esBisiesto;
        }
    }
}
