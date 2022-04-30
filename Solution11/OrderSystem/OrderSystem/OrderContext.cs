using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderSystemDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}
