using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monova.Entity.Objects;

namespace Monova.Entity
{
    public class MVDatabaseContext : IdentityDbContext<MVDatabaseUser , IdentityRole<Guid> , Guid>
    {
        public MVDatabaseContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
