using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Adibi.Authorization.Roles;
using Adibi.Authorization.Users;
using Adibi.MultiTenancy;
using Adibi.Salareis;
using Abp.EntityFrameworkCore;

namespace Adibi.EntityFrameworkCore
{
    public class AdibiDbContext : AbpZeroDbContext<Tenant, Role, User, AdibiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Salary> Salareis { get; set; }
        public AdibiDbContext(DbContextOptions<AdibiDbContext> options)
            
            : base(options)
        {
        }
    }
}
