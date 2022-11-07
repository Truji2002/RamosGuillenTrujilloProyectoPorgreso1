﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RamosGuillenTrujilloProyectoPorgreso1.Areas.Identity.Data;

namespace RamosGuillenTrujilloProyectoPorgreso1.Data;

public class RamosGuillenTrujilloProyectoPorgreso1Context5 : IdentityDbContext<ApplicationUser5>
{
    public RamosGuillenTrujilloProyectoPorgreso1Context5(DbContextOptions<RamosGuillenTrujilloProyectoPorgreso1Context5> options)
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
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser5>
{
    public void Configure(EntityTypeBuilder<ApplicationUser5> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}