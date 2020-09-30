using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 2, 6, 5, 8, 9, 45, 98, 90 };
            List<int> numerosPares = numeros.Where(n => n % 2 == 0).OrderByDescending(num => num).ToList();
            foreach(var num in numerosPares)
            {
                Console.WriteLine(num);
            }

        }
    }
}
