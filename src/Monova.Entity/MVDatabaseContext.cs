using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monova.Entity.Objects;

namespace Monova.Entity
{
    public class MVDatabaseContext : IdentityDbContext<MVDatabaseUser>
    {
        public MVDatabaseContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
