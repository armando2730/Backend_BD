using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_BD.Models
{
    public class Profesores
    {
       public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sueldo { get; set; }
        public string Edad { get; set; }
    }
}