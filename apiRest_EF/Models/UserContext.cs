using apiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace apiRest_EF.Models;

public class UserContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }

    public UserContext()
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Users");
    }
}
