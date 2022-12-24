using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredersUotput.DB
{
    public class MyContext:DbContext
    {
        string cs = "server = 192.168.232.169; database=ReBase; user id = sa; password = sa";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        public DbSet<Order> orders { get; set; }

    }
}
