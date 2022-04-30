using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class GoodHandler
    {
        public GoodHandler() { }
        public static void addGood(Good good)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    db.Goods.Add(good);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"The process of add good { good.Name } is wrong.");
            }
        }
        public static void deleteClient(int id)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var good = db.Goods.FirstOrDefault(g => g.GoodId == id);
                    db.Goods.Remove(good);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"The process of delete good { id } is wrong.");
            }
        }
        public static List<Good> getAllGood()
        {
            using (var db = new OrderContext())
            {
                return db.Goods.ToList();
            }
        }
    }
}
