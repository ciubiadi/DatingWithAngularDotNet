namespace API.Data;

using API.Entities;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) {

    }

    // name of the table
    public DbSet<AppUser> Users { get; set; }
}