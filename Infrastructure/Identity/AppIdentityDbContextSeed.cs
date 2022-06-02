using System;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed 
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Marius",
                    Email = "marius@test.com",
                    UserName = "marius@test.com",
                    Address = new Address
                    {
                        FirstName = "Marius",
                        LastName = "Nechita",
                        Street = "Aleea Castanilor nr. 18",
                        City = "Brasov",
                        State = "Romania",
                        ZipCode = "755902"
                    }
                };
            
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }

        }
    }
}