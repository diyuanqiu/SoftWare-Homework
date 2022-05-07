using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderSysAPI.Entity{

    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}