using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessActivityApi.Model;

namespace FitnessActivityApi.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<UserDetails> userDetails { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
