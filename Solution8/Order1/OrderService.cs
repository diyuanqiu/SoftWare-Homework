using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order1
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService() { }
        public Order getOrder(int no)
        {
            return orders.Where(o => o.orderNo == no).FirstOrDefault();
        }
        public void sortOrder()
        {
            orders.Sort((p1, p2) => p1.orderNo - p2.orderNo);
        }
        public void addOrder(Order order)
        {
            if (order == null)
            {
                throw new Exception("The adding order is null.");
            }
            if (orders.Contains(order)) {
                throw new ApplicationException($"the order {order.orderNo} already exists!");
            }
            orders.Add(order);
        }
        public void deleteOrder(Order order) // int orderNo
        {
            try
            {
                orders.Remove(order);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process of Delete Order is wrong.");
                Console.WriteLine(e.Message);
            }
        }
        public void changeOrder(Order newOrder)
        {
            try
            {
                foreach (Order order in orders)
                {
                    if (order.orderNo == newOrder.orderNo)
                    {
                        orders.Remove(order);
                        orders.Add(newOrder);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process of Change Order is wrong.");
                Console.WriteLine(e.Message);
            }
        }
        public List<Order> queryByOrderNo(int orderNo)
        {
            var query = from s in orders
                        where s.orderNo == orderNo
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByGoodName(string name)
        {
            var query = from s in orders
                        from d in s.orderDetails
                        where d.orderedGood.goodName == name
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByClient(string name)
        {
            var query = from s in orders
                        where s.client.clientName == name
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByOrderPrice(string price)
        {
            var query = from s in orders
                        where s.orderPrice >= int.Parse(price)
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public void Export(String filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("Orders.xml"));
        }
        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fs);
                temp.ForEach(order =>
                {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
    }
}
