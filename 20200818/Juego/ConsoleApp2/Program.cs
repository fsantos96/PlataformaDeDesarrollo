using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, numeroSistema;
            float apuesta = 0;
            var random = new Random();
            string mensaje;
            Console.WriteLine("Bienvenido al juego de apuestas" + Environment.NewLine);
            Console.WriteLine("Debe ingresar un numero entero, el cual sera comparado a una apuesta del sistema");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Debe ingresar un numero entero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Debe ingresar su apuesta");
            apuesta = float.Parse(Console.ReadLine());
            numeroSistema = random.Next(numero + 1);

            if (numero > numeroSistema)
            {
                mensaje = "Has ganado la apuesta duplicaste lo invertido: " + apuesta * 2;
            } else if(numero < numeroSistema)
            {
                mensaje = "Has perdido la apuesta pierdes lo invertido ( apuesta del sistema:" + numeroSistema + ")";
            } else
            {
                mensaje = "La apuesta resulto en empate, recibes lo invetido: " + apuesta;
            }

            Console.WriteLine(mensaje);
            Console.ReadLine();
        }
    }
}
