using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {
        public Task<List<Recurso>> getAll()
        {
            var ctx = new TaskDbContext();
            List<Recurso> listaRecursos = OperacionesDB.ObtenerTodo<Recurso>();

            return Task.FromResult(listaRecursos);
        }
    }
}
