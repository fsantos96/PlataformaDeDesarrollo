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
    public class DetalleController : ControllerBase
    {
 
        private readonly ILogger<DetalleController> _logger;

        public DetalleController(ILogger<DetalleController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Tarea/{id}")]
        public List<Detalle> GetAllByTaskId(int id)
        {
            List<Detalle> listaDetalle = OperacionesDB.ObtenerTodoInclude<Detalle, Recurso>(d => d.Recurso);
            List<Detalle> listaFiltrada = listaDetalle.FindAll(d => d.TareaId == id);
            return listaDetalle;
        }

        [HttpGet("{id}")]
        public Detalle GetById(int id)
        {
            Detalle detalle = OperacionesDB.ObtenerPorId<Detalle>(id);

            return detalle;
        }

        [HttpPost]
        public Detalle CreateRecurso(Detalle detalle)
        {
            OperacionesDB.Insertar<Detalle>(detalle);

            return detalle;
        }

        [HttpPut]
        public Detalle EditRecurso(Detalle detalle)
        {
            OperacionesDB.Actualizar<Detalle>(detalle);

            return detalle;
        }

        [HttpDelete("{id}")]
        public void DeleteRecurso(int id)
        {
            OperacionesDB.Borrar<Detalle>(id);
        }
    }
}
