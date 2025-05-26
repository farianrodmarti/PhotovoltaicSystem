using Microsoft.EntityFrameworkCore;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Domain.Entities.Abstract;
using PhotovoltaicSystem.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        #region Tables
        public DbSet <Housing> Housings => Set<Housing>();
        public DbSet<Inverter> Inverters => Set<Inverter>();
        public DbSet<PhotovoltaicSystemInstall> PhotovoltaicSystemInstalls => Set<PhotovoltaicSystemInstall>();
        public DbSet<SolarPanel> SolarPanels => Set<SolarPanel>();
        public DbSet<MaintenanceRecord> Maintenances => Set<MaintenanceRecord>();
        #endregion

        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        public AppDbContext()
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="connectionString">
        /// Cadena de conexión.
        /// </param>
        public AppDbContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="options">
        /// Opciones del contexto.
        /// </param>
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        #region Helpers

        private static DbContextOptions GetOptions(string connectionString)
        {
            return NpgsqlDbContextOptionsBuilderExtensions.UseNpgsql(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion

    }
}

