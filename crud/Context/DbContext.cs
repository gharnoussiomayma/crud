using crud.Pages.Client;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }

    public DbSet<ClientInfo> Client { get; set; }
}
