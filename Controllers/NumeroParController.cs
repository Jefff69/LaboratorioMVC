using System.Web.Mvc;
using LaboratorioMVC.Models;

namespace LaboratorioMVC.Controllers
{
    public class NumeroParController : Controller
    {
        // Muestra el formulario inicial.
        [HttpGet]
        public ActionResult Index()
        {
            return View(new NumeroPar());
        }

        // Procesa el número introducido por el usuario.
        [HttpPost]
        public ActionResult Index(NumeroPar modelo)
        {
            if (modelo.Numero.HasValue)
            {
                // Verificamos si el número es par.
                modelo.VerificarParidad();

                // Indicamos que se realizó la comprobación.
                ViewBag.Verificado = true;
            }

            return View(modelo);
        }
    }
}