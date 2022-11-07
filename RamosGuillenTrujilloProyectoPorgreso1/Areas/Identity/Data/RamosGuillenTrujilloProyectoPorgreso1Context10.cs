using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RamosGuillenTrujilloProyectoPorgreso1.Areas.Identity.Data;
using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Data;

public class RamosGuillenTrujilloProyectoPorgreso1Context10 : IdentityDbContext<ApplicationUser>
{
    public RamosGuillenTrujilloProyectoPorgreso1Context10(DbContextOptions<RamosGuillenTrujilloProyectoPorgreso1Context10> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);



        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public DbSet<RamosGuillenTrujilloProyectoPorgreso1.Models.Conductor> Conductor { get; set; }

    public DbSet<RamosGuillenTrujilloProyectoPorgreso1.Models.Transporte> Transporte { get; set; }

    public DbSet<RamosGuillenTrujilloProyectoPorgreso1.Models.Ruta> Ruta { get; set; }

}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}
