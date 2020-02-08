using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfMarket.Models;
using Microsoft.Extensions.Hosting;
using MySql.Data.EntityFrameworkCore;


namespace InfMarket.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) 
            : base(dbContextOptions)
        { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
