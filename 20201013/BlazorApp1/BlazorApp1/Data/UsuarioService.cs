using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        public Task<List<Usuario>> getAll()
        {
            var ctx = new TaskDbContext();
            List<Usuario> listaUsuarios = OperacionesDB.ObtenerTodo<Usuario>();

            return Task.FromResult(listaUsuarios);
        }
    }
}
