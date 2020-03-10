using BusinessManager.Application.Interfaces;
using BusinessManager.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Infrastructure.Identity.Context
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>, IIdentityContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
    }
}
