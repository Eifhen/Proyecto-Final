using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalCodeFirst.Models
{
	public class Empleado
	{
		public  int id  { get; set; }
		[Required(ErrorMessage = "Obligatorio")]
		public String NombreEmpleado { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public String ApellidoEmpleado { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public long Telefono { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public String Departamento { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public String Cargo { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public long Salario { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public DateTime Fecha { get; set; }

		[Required(ErrorMessage = "Obligatorio")]
		public EstadoEmpleado Estado { get; set; }

		public enum EstadoEmpleado
		{
			 Activo,
			 Inactivo

		}

		

	}
}
