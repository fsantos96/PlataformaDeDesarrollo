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
    public class RecursoController : ControllerBase
    {
 
        private readonly ILogger<RecursoController> _logger;

        public RecursoController(ILogger<RecursoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Recurso> GetAll()
        {
            List<Recurso> listaRecursos = OperacionesDB.ObtenerTodoInclude<Recurso, Usuario>(r => r.Usuario);

            return listaRecursos;
        }

        [HttpGet("{id}")]
        public Recurso GetById(int id)
        {
            Recurso recurso = OperacionesDB.ObtenerPorId<Recurso>(id);

            return recurso;
        }

        [HttpPost]
        public Recurso CreateRecurso(Recurso recurso)
        {
            OperacionesDB.Insertar<Recurso>(recurso);

            return recurso;
        }

        [HttpPut]
        public Recurso EditRecurso(Recurso recurso)
        {
            OperacionesDB.Actualizar<Recurso>(recurso, recurso.Id);

            return recurso;
        }

        [HttpDelete("{id}")]
        public void DeleteRecurso(int id)
        {
            OperacionesDB.Borrar<Recurso>(id);
        }
    }
}
