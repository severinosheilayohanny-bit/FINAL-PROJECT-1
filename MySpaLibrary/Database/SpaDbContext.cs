using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySpaLibrary.Models;

namespace MySpaLibrary.Database;

public class SpaDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Service> Services { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Appointment> Appointments { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<Commission> Commissions { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=SHEILALONGA\\SQLEXPRESS;Database=SheiGlow_Spa_Manager;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Client>().ToTable("Client");
        modelBuilder.Entity<Service>().ToTable("Service");
        modelBuilder.Entity<Employee>().ToTable("Employee");
        modelBuilder.Entity<Appointment>().ToTable("Appointment");
        modelBuilder.Entity<Payment>().ToTable("Payment");
        modelBuilder.Entity<Commission>().ToTable("Commission");


        modelBuilder.Entity<Service>().HasIndex(s => s.Name);
        modelBuilder.Entity<Appointment>().HasIndex(a => a.StartAt);
    }
}
