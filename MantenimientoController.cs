using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalCodeFirst.Models;

namespace FinalCodeFirst.Controllers
{
    public class MantenimientoController : Controller
    {
		// GET: Mantenimiento

		Contexto BD = new Contexto();


		// *****************************************************************
		//                   Modulo de Mantenimiento
		// ******************************************************************



		[HttpGet]
		public ActionResult Departamento()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Departamento(Departamento dep)
		{

			BD.Departamentos.Add(dep);
			BD.SaveChanges();
			return RedirectToAction("TablaDepartamento");		

		}

		public ActionResult TablaDepartamento()
		{
			return View(BD.Departamentos.ToList());
		}

		[HttpGet]
		public ActionResult Cargo()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Cargo(Cargo c)
		{

			BD.Cargos.Add(c);
			BD.SaveChanges();
			return RedirectToAction("TablaCargos");
		}

		public ActionResult TablaCargos()
		{
			return View(BD.Cargos.ToList());
		}
		
		
		[HttpGet]
		public ActionResult Empleado()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Empleado(Empleado emp)
		{

			BD.Empleados.Add(emp);
			BD.SaveChanges();
			return RedirectToAction("Enviado");
		}
		public ActionResult Enviado()
		{
			return View();
		}

		
	}
}
