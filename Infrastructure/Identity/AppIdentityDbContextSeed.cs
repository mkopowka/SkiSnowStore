using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Matt",
                    Email = "matt@test.com",
                    UserName ="matt@test.com",
                    Address = new Address
                    {
                        FirstName="Matt",
                        LastName="Key",
                        Street="10 The Street",
                        City="New York",
                        State="NY",
                        ZipCode="9210"
                    }
                
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        } 
    }
}