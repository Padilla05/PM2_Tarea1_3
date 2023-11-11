// Services/DatabaseService.cs
using Microsoft.EntityFrameworkCore;
using PM2_Tarea1_3.Models;
using System.IO;
using Xamarin.Essentials;

public class DatabaseService : DbContext
{
    public DbSet<Personas> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "miBaseDeDatos.db3");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
