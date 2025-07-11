using Microsoft.EntityFrameworkCore;
using SalesUploader.Models;

namespace SalesUploader.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    public DbSet<SalesLead> SalesLeads => Set<SalesLead>();
}
