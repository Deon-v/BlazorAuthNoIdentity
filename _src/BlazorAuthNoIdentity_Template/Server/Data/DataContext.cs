using Microsoft.EntityFrameworkCore;

namespace BlazorAuthNoIdentity.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<User>? Users { get; set; }
        public DbSet<UserRoles>? UserRoles { get; set; }
    }
}
