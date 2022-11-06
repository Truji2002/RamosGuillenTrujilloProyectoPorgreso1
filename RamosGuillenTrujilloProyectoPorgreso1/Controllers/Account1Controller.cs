using Microsoft.AspNetCore.Mvc;
using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Controllers
{
    public class Account1Controller : Controller
    {
        [Route("registrocliente")]
        public IActionResult RegistrarseCliente()
        {
            return View();
        }

        [Route("registrocliente")]
        [HttpPost]
        public IActionResult RegistrarseCliente(Conductor conductor)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
