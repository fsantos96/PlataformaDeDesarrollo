using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Entities;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Usuario> GetAll()
        {
            List<Usuario> listaUsuarios = OperacionesDB.ObtenerTodo<Usuario>();

            return listaUsuarios;
        }

        [HttpGet("{id}")]
        public Usuario GetById(int id)
        {
            Usuario usuario = OperacionesDB.ObtenerPorId<Usuario>(id);

            return usuario;
        }

        [HttpPost]
        public Usuario CreateUsuario(Usuario usuario)
        {
            OperacionesDB.Insertar<Usuario>(usuario);

            return usuario;
        }

        [HttpPut]
        public Usuario EditUsuario(Usuario usuario)
        {
            OperacionesDB.Actualizar<Usuario>(usuario);

            return usuario;
        }

        [HttpDelete("{id}")]
        public void DeleteUsuario(int id)
        {
            OperacionesDB.Borrar<Usuario>(id);
        }
    }
}
