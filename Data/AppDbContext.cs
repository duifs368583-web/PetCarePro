using Microsoft.EntityFrameworkCore;
using PetCarePro.Components.Pages;

namespace PetCarePro.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Clients> Clients { get; set; }
}

public class Clients
{
    public int Id { get; set; }
    private static string Name { get; set; }
    private string Address { get; set; }
    private string Zipcode { get; set; }
    private string City { get; set; }
}
            
            