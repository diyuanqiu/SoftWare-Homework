using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class ClientHandler
    {
        public ClientHandler() { }
        public static void addClient(Client client)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"The process of add client { client.Name } is wrong.");
            }
        }
        public static void deleteClient(int id)
        {
            try
            {
                using(var db = new OrderContext())
                {
                    var client = db.Clients.FirstOrDefault(c => c.ClientId == id);
                    db.Clients.Remove(client);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"The process of delete client { id } is wrong.");
            }
        }
        public static List<Client> getAllClient()
        {
            using (var db = new OrderContext())
            {
                return db.Clients.ToList();
            }
        }
    }
}
