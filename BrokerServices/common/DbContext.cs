
using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerServices.common
{
    public class dbContext : DbContext
    {
        //public dbContext(DbContextOptions<dbContext> options)
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConn = "Server = 70.37.80.92; port = 5432; Database = fundabien; User Id = postgres; Password = Fundabien@2019; Pooling = true; MinPoolSize = 1; MaxPoolSize = 20; ";
            optionsBuilder.UseNpgsql(stringConn);
        }

        public DbSet<Autor> Autores { get; set; }
    }
    
}
