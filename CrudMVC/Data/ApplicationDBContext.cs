using CrudMVC.Data.SeedData;
using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }


    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Contact>().HasData(ContactSeedData.GetContacts());
    }
}
