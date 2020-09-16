using System;
using ClassLibrary;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(10, 23));
            Console.WriteLine(calculadora.Multiplicar(7, 13));
            Console.WriteLine(calculadora.Dividir(10, 0));
            Console.WriteLine(calculadora.Restar(10, 23));
        }
    }
}
