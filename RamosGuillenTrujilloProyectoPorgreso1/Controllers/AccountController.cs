using Microsoft.AspNetCore.Mvc;

namespace RamosGuillenTrujilloProyectoPorgreso1.Controllers
{
    public class AccountController : Controller
    {
        [Route("registrarse")]

        public IActionResult IniciarSesion()
        {
            return View();
        }
    }
}
