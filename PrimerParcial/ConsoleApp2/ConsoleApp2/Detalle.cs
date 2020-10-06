using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Detalle
    {
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}
