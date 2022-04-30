using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderService
    {
        public OrderService() { }
        public static List<Order> getAllOrder()
        {
            using(var db = new OrderContext())
            {
                return db.Orders.ToList();
            }
        }
        public static IQueryable<Order> getAllOrder(OrderContext db)
        {
            return db.Orders.Include("Client").Include(o => o.Details.Select(d => d.Good));
        }
        public Order getOrder(int id)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = getAllOrder(db).FirstOrDefault(o => o.Id == id);
                    return order;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Can't find the order with the id {id}.");
            }
        }
        public void addOrder(Order order)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"The process of add order {order} is wrong.");
            }
        }
        public void deleteOrder(int id)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = db.Orders.FirstOrDefault(o => o.Id == id);
                    if (order != null)
                    {
                        db.Orders.Remove(order);
                        db.SaveChanges();
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception($"The process of delete order {id} is wrong.");
            }
        }
        public void updateOrder(Order order)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var oldOrder = db.Orders.FirstOrDefault(o => o.Id == order.Id);
                    db.Entry(oldOrder).State = EntityState.Modified;
                    oldOrder.Id = order.Id;
                    oldOrder.Client = order.Client;
                    oldOrder.Details = order.Details;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"The process of update order {order.Id} is wrong.");
            }
        }
        public List<Order> queryByOrderId(int id)
        {
            using(var db = new OrderContext())
            {
                var query = getAllOrder(db).Where(o => o.Id == id);
                return query.ToList();
            }
        }
        public List<Order> queryByClientName(string name)
        {
            using (var db = new OrderContext())
            {
                var query = getAllOrder(db).Where(o => o.Client.Name == name);
                return query.ToList();
            }
        }
        public List<Order> queryByGoodName(string name)
        {
            using (var db = new OrderContext())
            {
                var query = getAllOrder(db).Where(o => o.Details.Count(i => i.Good.Name == name) > 0);
                return query.ToList();
            }
        }
        public List<Order> queryByPrice(string price)
        {
            using (var db = new OrderContext())
            {
                var query = getAllOrder(db).Where(o => o.totalPrice >= double.Parse(price)).OrderBy(o => o.Id);
                return query.ToList();
            }
        }
        public void Export(String filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, getAllOrder());
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
                    if (!getAllOrder().Contains(order))
                    {
                        getAllOrder().Add(order);
                    }
                });
            }
        }
    }
}
