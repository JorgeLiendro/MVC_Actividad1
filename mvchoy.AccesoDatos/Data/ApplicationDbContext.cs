using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Poner aquí todos los modelos que se vayan creando
        public DbSet<Almacen> Almacen { get; set; }

        //modelos añadidos
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Profesion> Profesion { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<ProyectoTrabajador> ProyectoTrabajador { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la clave compuesta para ProyectoTrabajador
            modelBuilder.Entity<ProyectoTrabajador>()
                .HasKey(pt => new { pt.CodProyecto, pt.Ci, pt.CodProfesion });
        }
    } 

}
