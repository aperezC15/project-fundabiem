using Autofac;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;


namespace BrokerServices.common
{
    public class connectionSQL
    {
        private readonly string uri;
        public connectionSQL(string uri, ILogger logger)
        {
            this.uri = uri;
        }
       
        public static DbContextOptions<dbContext> con(string ur)
        {
            var builder = new DbContextOptionsBuilder<dbContext>();
            DbContextConfigure.Configure(builder, ur);

            return builder.Options;
        }

    }
}
