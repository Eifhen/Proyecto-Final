using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCodeFirst.Models
{
    public class SalidaEmpleado
    {
        public int id { get; set; }
        public String Empleado { get; set; }
        public String TipoSalida { get; set; }
        public String Motivo { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
    }
}