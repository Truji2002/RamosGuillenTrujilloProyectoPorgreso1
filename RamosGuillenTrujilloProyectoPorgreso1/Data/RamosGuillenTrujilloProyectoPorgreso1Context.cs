using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Data
{
    public class RamosGuillenTrujilloProyectoPorgreso1Context : DbContext
    {
        public RamosGuillenTrujilloProyectoPorgreso1Context (DbContextOptions<RamosGuillenTrujilloProyectoPorgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<RamosGuillenTrujilloProyectoPorgreso1.Models.Conductor> Conductor { get; set; } = default!;

        public DbSet<RamosGuillenTrujilloProyectoPorgreso1.Models.Usuario> Usuario { get; set; }
    }
}
