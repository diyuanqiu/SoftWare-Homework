using System;
using System.Collections.Generic;
using System.Linq;
namespace Solution5{
    class OrderService
    {
        public List<Order> orders = new List<Order>();
        public OrderService(List<Order> orders){
            this.orders = orders;
        }
        public OrderService(){}
        public void sortOrder(){
            orders.Sort((p1, p2) => p1.orderNo - p2.orderNo);
        }
        public void addOrder(Order order){
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
        public void changeOrder(int orderNo,Order newOrder){
            try{
                foreach(Order order in orders){
                    if(order.orderNo == orderNo){
                        orders.Remove(order);
                        orders.Add(newOrder);
                    }
                }
            }
            catch(Exception e){
                Console.WriteLine("The process of Change Order is wrong.");
                Console.WriteLine(e.Message);
            }
        }
        public List<Order> queryByOrderNo(int orderNo){
            var query = from s in orders
                        where s.orderNo == orderNo
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByGoodName(string name){
            var query = from s in orders
                        from d in s.orderDetails
                        where d.orderedGood.goodName == name
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByClient(string name){
            var query = from s in orders
                        where s.client.clientName == name
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
        public List<Order> queryByOrderPrice(string price){
            var query = from s in orders
                        where s.orderPrice == int.Parse(price)
                        orderby s.orderNo
                        select s;
            return query.ToList();
        }
    }
}