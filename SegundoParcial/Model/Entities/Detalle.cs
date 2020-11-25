using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Detalle
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public int? RecursoId { get; set; }
        public Tarea Tarea { get; set; }
        public int TareaId { get; set; }
    }
}
