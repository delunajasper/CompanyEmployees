using CompanyEmployees.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CompanyConfiguration());
        builder.ApplyConfiguration(new EmployeeConfiguration());
    }
    
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Employee>? Employees { get; set; }
}