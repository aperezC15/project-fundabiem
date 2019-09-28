using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerServices.common
{
    class DbContextConfigure
    {
        public static void Configure(DbContextOptionsBuilder<dbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }
    }
}
