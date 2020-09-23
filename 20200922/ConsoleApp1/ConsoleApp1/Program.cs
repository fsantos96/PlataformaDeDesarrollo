using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarea tarea1 = new Tarea();
            Recurso persona1 = new Recurso();
            Recurso persona2 = new Recurso();
            persona1.Nombre = "Federico Santos";
            persona2.Nombre = "Tatiana Andonegui";
     
            Tarea tarea2 = new Tarea();
            Tarea tarea3 = new Tarea();
            Tarea tarea4 = new Tarea();
            Tarea tarea5 = new Tarea();

            tarea1.Titulo = "Titulo 1";
            tarea1.Vencimiento = DateTime.Parse("23/09/2020");
            tarea1.Estimacion = 10;
            tarea1.Estado = true;
            
            tarea2.Titulo = "Titulo 2";
            tarea2.Vencimiento = DateTime.Parse("21/09/2020");
            tarea2.Estimacion = 10;
            tarea2.Responsable = persona2;
            tarea2.Estado = false;

            tarea3.Titulo = "Titulo 3";
            tarea3.Vencimiento = DateTime.Parse("29/09/2020");
            tarea3.Estimacion = 10;
            tarea3.Responsable = persona1;
            tarea3.Estado = true;

            tarea4.Titulo = "Titulo 4";
            tarea4.Vencimiento = DateTime.Parse("29/09/2020");
            tarea4.Estimacion = 10;
            tarea4.Responsable = persona1;
            tarea4.Estado = true;

            tarea1.Titulo = "Titulo 5";
            tarea1.Vencimiento = DateTime.Parse("13/09/2020");
            tarea1.Estimacion = 10;
            tarea1.Estado = false;

            List<Tarea> listaTareas = new List<Tarea>();
            listaTareas.Add(tarea1);
            listaTareas.Add(tarea2);
            listaTareas.Add(tarea3);
            listaTareas.Add(tarea4);
            listaTareas.Add(tarea5);
        }
    }
}
