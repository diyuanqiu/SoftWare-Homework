using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Client client = new Client(2, "Diyuan");
            Good game1 = new Good(1, "Death cell", 38);
            Good game2 = new Good(2, "Empty Knight", 78);
            Good game3 = new Good(3, "Elda halo", 199);
            Good game4 = new Good(4, "GTA V", 99);
            OrderDetail detail1 = new OrderDetail(1, game1, 3);
            OrderDetail detail2 = new OrderDetail(2, game2, 4);
            OrderDetail detail3 = new OrderDetail(3, game3, 5);
            OrderDetail detail4 = new OrderDetail(4, game4, 6);
            List<OrderDetail> Detail1 = new List<OrderDetail> { detail1, detail2, detail3, detail4 };
            List<OrderDetail> Detail2 = new List<OrderDetail> { detail1, detail3 };
            List<OrderDetail> Detail3 = new List<OrderDetail> { detail2, detail4 };
            Order order1 = new Order(1, client, Detail1);
            Order order2 = new Order(2, client, Detail2);
            Order order3 = new Order(3, client, Detail3);
            try
            {
                using (var db = new OrderContext())
                {
                    db.Orders.Add(order1);
                    db.Orders.Add(order2);
                    var orders = db.Orders.ToList();
                    foreach (Order order in orders)
                    {
                        Console.WriteLine(order.ToString());
                    }
                    /*orderService.deleteOrder(1);
                    foreach (Order order in orders)
                    {
                        Console.WriteLine(order.ToString());
                    }*/
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
