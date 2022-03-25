using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Diyuan");
            Good game1 = new Good("Death cell", 38);
            Good game2 = new Good("Empty Knight", 78);
            Good game3 = new Good("Elda halo", 199);
            Good game4 = new Good("GTA V", 99);
            Good game5 = new Good("Gmod", 28);
            OrderDetails gameDetail1 = new OrderDetails(game1, 3);
            OrderDetails gameDetail2 = new OrderDetails(game2, 2);
            OrderDetails gameDetail3 = new OrderDetails(game3, 5);
            OrderDetails gameDetail4 = new OrderDetails(game4, 6);
            OrderDetails[] Detail1 = { gameDetail1, gameDetail2, gameDetail3, gameDetail4 };
            OrderDetails[] Detail2 = { gameDetail1, gameDetail3 };
            OrderDetails[] Detail3 = { gameDetail2, gameDetail4 };
            Order order1 = new Order(client, 1, Detail1);
            Order order2 = new Order(client, 1, Detail2);
            Order order3 = new Order(client, 3, Detail3);
            //Console.WriteLine(order1.ToString());
            //Console.WriteLine(order2.ToString());
            //Console.WriteLine(order3.ToString());
            OrderService service = new OrderService();
            service.addOrder(order1);
            service.addOrder(order2);
            service.addOrder(order3);
            //foreach(Order order in service.queryByOrderNo(1)){
            //    Console.WriteLine(order.ToString());
            //}
            service.deleteOrder(order2);
            //foreach (Order order in service.queryByOrderNo(1))
            //{
            //    Console.WriteLine(order.ToString());
            //}
            service.Export();
            service.Import();
            Console.ReadKey();
        }
    }
}

