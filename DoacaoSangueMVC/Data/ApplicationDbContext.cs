using DoacaoSangueMVC.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoacaoSangueMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SangueColetado> SangueColetados { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Hemocentro> Hemocentros { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<DadosMedico> DadosMedicos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var cargoAdmin = new IdentityRole("admin");
            cargoAdmin.NormalizedName = "admin";

            var usuario = new IdentityRole("usuario");
            usuario.NormalizedName = "usuario";

            var hemocentro = new IdentityRole("hemocentro");
            hemocentro.NormalizedName = "hemocentro";

            builder.Entity<IdentityRole>().HasData(cargoAdmin, usuario, hemocentro);
        }
    }
}

