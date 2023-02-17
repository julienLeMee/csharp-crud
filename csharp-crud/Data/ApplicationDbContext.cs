using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using csharp_crud.Models;

namespace csharp_crud.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<csharp_crud.Models.Fruit> Fruits { get; set; } = default!; // permet de créer une table dans la base de données

    public DbSet<csharp_crud.Models.Image> Images { get; set; } = default!;
}
