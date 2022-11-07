using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RamosGuillenTrujilloProyectoPorgreso1.Areas.Identity.Data;

namespace RamosGuillenTrujilloProyectoPorgreso1.Data;

public class RamosGuillenTrujilloProyectoPorgreso1Context1 : IdentityDbContext<ApplicationUser>
{
    public RamosGuillenTrujilloProyectoPorgreso1Context1(DbContextOptions<RamosGuillenTrujilloProyectoPorgreso1Context1> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
