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
    public class TareaController : ControllerBase
    {
        private readonly ILogger<TareaController> _logger;

        public TareaController(ILogger<TareaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Tarea> GetAll()
        {
            List<Tarea> listaTareas = OperacionesDB.ObtenerTodo<Tarea>();

            return listaTareas;
        }

        [HttpGet("{id}")]
        public Tarea GetById(int id)
        {
            Tarea tarea = OperacionesDB.ObtenerPorId<Tarea>(id);

            return tarea;
        }

        [HttpPost]
        public Tarea CreateUsuario(Tarea tarea)
        {
            OperacionesDB.Insertar<Tarea>(tarea);

            return tarea;
        }

        [HttpPut]
        public Tarea EditUsuario(Tarea tarea)
        {
            OperacionesDB.Actualizar<Tarea>(tarea);

            return tarea;
        }

        [HttpDelete("{id}")]
        public void DeleteUsuario(int id)
        {
            OperacionesDB.Borrar<Tarea>(id);
        }
    }
}
