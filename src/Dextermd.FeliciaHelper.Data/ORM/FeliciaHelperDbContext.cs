using Dextermd.FeliciaHelper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dextermd.FeliciaHelper.Data.ORM
{
    public class FeliciaHelperDbContext : DbContext
    {
        public FeliciaHelperDbContext(DbContextOptions<FeliciaHelperDbContext> options) : base(options)
        {
        }

        public DbSet<Mural> Mural { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}
