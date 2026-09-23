using System;
using System.Web.Mvc;
using LaboratorioMVC.Models;

namespace LaboratorioMVC.Controllers
{
    public class DiaSemanaController : Controller
    {
        // Muestra el formulario inicial.
        [HttpGet]
        public ActionResult Index()
        {
            return View(new DiaSemana());
        }

        // Procesa el número introducido por el usuario.
        [HttpPost]
        public ActionResult Index(DiaSemana modelo)
        {
            // Si no se introduce ningún número, obtenemos el día actual.
            if (!modelo.NumeroDia.HasValue)
            {
                modelo.NumeroDia = (int)DateTime.Now.DayOfWeek;

                // En .NET, Sunday = 0 y Monday = 1.
                // Ajustamos el domingo para que sea el día 7.
                if (modelo.NumeroDia == 0)
                {
                    modelo.NumeroDia = 7;
                }
            }

            // Validamos que el número esté entre 1 y 7.
            if (modelo.NumeroDia < 1 || modelo.NumeroDia > 7)
            {
                ModelState.AddModelError(
                    "NumeroDia",
                    "Ingrese un número entre 1 y 7."
                );

                return View(modelo);
            }

            // Convertimos el número en el nombre del día.
            string[] dias =
            {
                "",
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábado",
                "Domingo"
            };

            modelo.NombreDia = dias[modelo.NumeroDia.Value];

            return View(modelo);
        }
    }
}