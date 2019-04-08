using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCodeFirst.Models
{
    public class Vacaciones
    {
        public int id { get; set; }
        public String Empleado { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public String Comentarios { get; set; }

    }
}