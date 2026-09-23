using System.Web.Mvc;
using LaboratorioMVC.Models;

namespace LaboratorioMVC.Controllers
{
    public class SalarioController : Controller
    {
        // Muestra el formulario de cálculo del salario.
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // Procesa los datos enviados desde el formulario.
        [HttpPost]
        public ActionResult Index(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                // Calculamos el salario utilizando el modelo.
                decimal salario = empleado.CalcularSalario();

                // Enviamos el resultado a la vista.
                ViewBag.Salario = salario;
            }

            return View(empleado);
        }
    }
}