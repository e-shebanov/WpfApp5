using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class DataContext : DbContext
    {
        public DbSet<Pipe> Pipes { get; set; }
        //public DbSet<Package> Packages { get; set; }

        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=db.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
