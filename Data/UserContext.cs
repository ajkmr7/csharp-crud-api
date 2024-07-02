using csharp_crud_api.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Data
{
    public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}