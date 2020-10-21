using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Data
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        [MinLength(8)]
        public string Clave { get; set; }
    }
}
