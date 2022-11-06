using Microsoft.AspNetCore.Mvc;

using RamosGuillenTrujilloProyectoPorgreso1.Models;
using RamosGuillenTrujilloProyectoPorgreso1.Repository;

namespace RamosGuillenTrujilloProyectoPorgreso1.Controllers
{
    public class AccountController : Controller
    {
        [Route("registroconductor")]
        public IActionResult RegistrarseConductor()
        {
            return View();
        }

        [Route("registroconductor")]
        [HttpPost]
        public IActionResult RegistrarseConductor(Conductor conductor)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
        }
    }
}
