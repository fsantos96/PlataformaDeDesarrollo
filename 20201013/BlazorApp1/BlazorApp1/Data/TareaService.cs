using BlazorApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
        public Task<List<Tarea>> getAll()
        {
            var ctx = new TaskDbContext();
            List<Tarea> listaTareas = OperacionesDB.ObtenerTodo<Tarea>();

            return Task.FromResult(listaTareas);
        }
    }
}
