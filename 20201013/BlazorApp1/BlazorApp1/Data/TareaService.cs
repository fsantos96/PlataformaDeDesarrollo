using BlazorApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Task<Tarea[]> getTareas()
        {
            Tarea[] listaTarea = new Tarea[10];
            for(var i = 0; i < 10; i++)
            {
                listaTarea[i] = new Tarea {Id=i, Estado= false, Estimacion=2, Titulo="Titulo" + i, Vencimiento=DateTime.Now };
            }

            return Task.FromResult(listaTarea);
        }
    }
}
