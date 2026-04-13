using Microsoft.EntityFrameworkCore;
using Phone_Book.Models;

namespace Phone_Book.Context;

internal class ContactContext : DbContext
{
    public static string ConnectionString { get; set; } = "";

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
}
