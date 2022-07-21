using Microsoft.EntityFrameworkCore;

namespace BlazorAuthNoIdentity.Server.Data
{
    public class SeedData
    {
        private static readonly User[] user = new User[]
        {
            new User()
            {
                Id = 1,
                Email = "admin@test.com",
                FirstName = "Admin",
                LastName = "Admin",
                Password = "Password@1234"
            },
            new User()
            {
                Id = 2,
                Email = "user1@test.com",
                FirstName = "One",
                LastName = "User",
                Password = "Password@1234"
            },
            new User()
            {
                Id = 3,
                Email = "user2@test.com",
                FirstName = "Two",
                LastName = "User",
                Password = "Password@1234"
            }
        };

        private static readonly UserRoles[] roles = new UserRoles[]
        {
            new UserRoles()
            {
                RoleName = "Admin",
                UserId = 1
            },
            new UserRoles()
            {
                RoleName = "Normal",
                UserId = 2,
            },
            new UserRoles()
            {
                RoleName = "Weather",
                UserId = 3
            }
        };

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new DataContext(
                       serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                _context.Users.AddRange(user);
                _context.UserRoles.AddRange(roles);
                _context.SaveChanges();
            }

            
        }
    }
}
