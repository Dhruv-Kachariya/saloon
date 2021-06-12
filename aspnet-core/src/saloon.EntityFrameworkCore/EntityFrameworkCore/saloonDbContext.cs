using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using saloon.Authorization.Roles;
using saloon.Authorization.Users;
using saloon.MultiTenancy;

namespace saloon.EntityFrameworkCore
{
    public class saloonDbContext : AbpZeroDbContext<Tenant, Role, User, saloonDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public saloonDbContext(DbContextOptions<saloonDbContext> options)
            : base(options)
        {
        }
    }
}
