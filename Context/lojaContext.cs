using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using api_tech.Models;

namespace api_tech.Context
{
    public class lojaContext : DbContext
    {
        public lojaContext(DbContextOptions<lojaContext>options) : base(options)
        {     
        }

        public DbSet<Venda>Vendas{ get; set; }
        public DbSet<Vendedor> Vendedors{ get; set; }
        public DbSet<Produto> Produtos{ get; set; }
    }
}