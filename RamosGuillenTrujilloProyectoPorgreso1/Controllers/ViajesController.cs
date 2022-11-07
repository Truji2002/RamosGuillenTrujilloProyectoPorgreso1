using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RamosGuillenTrujilloProyectoPorgreso1.Data;
using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Controllers
{
    public class ViajesController : Controller
    {
        private readonly RamosGuillenTrujilloProyectoPorgreso1Context10 _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ViajesController(RamosGuillenTrujilloProyectoPorgreso1Context10 context, IWebHostEnvironment webHost)
        {
            _context = context;
            webHostEnvironment = webHost;
        }
        public IActionResult Index()
        {
            List<Viaje> viajes = _context.Viaje.ToList();
            return View(viajes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Viaje viaje = new Viaje();
            return View(viaje);
        }

        [HttpPost]
        public ActionResult Create(Viaje viaje)
        {
            string uniqueFileName = UploadedFile(viaje);
            viaje.ImagenUrl = uniqueFileName;
            _context.Attach(viaje);
            _context.Entry(viaje).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private string UploadedFile(Viaje viaje)
        {
            string uniqueFileName = null;

            if (viaje.ImagenLugar != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + viaje.ImagenLugar.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    viaje.ImagenLugar.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
