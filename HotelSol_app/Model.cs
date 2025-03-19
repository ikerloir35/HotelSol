using HotelSol;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

public class HotelContext : DbContext
{
    public DbSet<Direccion> Direccion { get; set; }
    public DbSet<Hotel> Hotel { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Departamento> Departamento { get; set; }
    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Evento> Evento { get; set; }
    public DbSet<TipoAlojamiento> TipoAlojamiento { get; set; }
    public DbSet<Temporada> Temporada { get; set; }
    public DbSet<Servicio> Servicio { get; set; }
    public DbSet<Reserva> Reserva { get; set; }
    public DbSet<Factura> Factura { get; set; }
    public DbSet<Habitacion> Habitacion { get; set; }
    public DbSet<Producto> Producto { get; set; }

    // The following configures EF to create  SqlServer database tables
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["HotelSolDB"].ConnectionString;
            optionsBuilder.UseSqlServer(conn)
                            .LogTo(message => Debug.WriteLine(message))
                            .EnableDetailedErrors()
                            .EnableSensitiveDataLogging();
        }

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }

}
