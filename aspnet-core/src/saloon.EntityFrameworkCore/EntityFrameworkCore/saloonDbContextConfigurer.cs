using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace saloon.EntityFrameworkCore
{
    public static class saloonDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<saloonDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<saloonDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
