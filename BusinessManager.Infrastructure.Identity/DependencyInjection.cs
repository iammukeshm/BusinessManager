using BusinessManager.Application.Interfaces;
using BusinessManager.Infrastructure.Identity.Context;
using BusinessManager.Infrastructure.Identity.Helpers;
using BusinessManager.Infrastructure.Identity.Models;
using BusinessManager.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Infrastructure.Identity
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureIdentity(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            // Identity
            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));



            services.AddScoped<IIdentityContext>(provider => provider.GetService<IdentityContext>());


            //Adds/Injects UserManager Service
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>();


            // Services
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IIdentityService, IdentityService>();


            //Keep this always at last. JWT
            AuthenticationHelper.ConfigureService(services, configuration["JwtSecurityToken:Issuer"], configuration["JwtSecurityToken:Audience"], configuration["JwtSecurityToken:Key"]);

            return services;
        }

    }
}
