using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using BOL;
using System.Reflection.Emit;

namespace DAL;

public class CollectionContext : DbContext{
    public DbSet<User> user { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString = @"server=192.168.10.150;port=3306;user=dac2; password=welcome;database=dac2";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(entity =>{
            entity.HasKey(e => e.id);
            entity.Property(e => e.name);
            entity.Property(e => e.email);
            entity.Property(e => e.country);
        });
        modelBuilder.Entity<User>().ToTable("users");
    }
}

