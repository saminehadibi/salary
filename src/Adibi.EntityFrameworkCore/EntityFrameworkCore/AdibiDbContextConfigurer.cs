using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Adibi.EntityFrameworkCore
{
    public static class AdibiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AdibiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AdibiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
