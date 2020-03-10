using BusinessManager.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Infrastructure.Identity.Context
{
    public static class IdentityContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "iammukeshm",
                FirstName = "Mukesh",
                LastName = "Murugan",

                Email = "iammukeshm@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "7306488721",
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, "123Mukesh.");
            }
        }
    }
}
