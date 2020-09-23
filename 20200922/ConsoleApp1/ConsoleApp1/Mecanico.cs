using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Mecanico
    {
        public void Arreglar(IRespuesto repuesto)
        {
            Console.WriteLine(repuesto.Precio);
        }
    }
}
