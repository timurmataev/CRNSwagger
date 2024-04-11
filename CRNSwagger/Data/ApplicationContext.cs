using CRMSwagger.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CRMSwagger.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<UserDTO> Users { get; set; }
}
