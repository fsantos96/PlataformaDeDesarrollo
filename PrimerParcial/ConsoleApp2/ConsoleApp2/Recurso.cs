using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public virtual Detalle Detalle { get; set; }
        public int? DetalleId { get; set; }
    }
}
