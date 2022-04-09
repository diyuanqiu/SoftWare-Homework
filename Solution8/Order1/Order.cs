using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order1
{
    [Serializable]
    public class Order
    {
        public Client client { get; set; }
        public int orderNo { get; set; }
        public double orderPrice
        {
            get => orderDetails.Sum(orderDetail => orderDetail.orderdedGoodSumPrice);
        }
        public List<OrderDetails> orderDetails { get; set; }
        public OrderDetails getDetails(string name)
        {
            return orderDetails.Where(o => o.orderedGood.goodName == name).FirstOrDefault();
        }
        public Order() { }
        public Order(Client client, int orderNo, List<OrderDetails> orderDetails)
        {
            this.client = client;
            this.orderNo = orderNo;
            this.orderDetails = orderDetails;
        }
        //stringbuilder
        public override string ToString()
        {
            StringBuilder everyOrderDetail = new StringBuilder();
            foreach (OrderDetails orderDetails in orderDetails)
            {
                everyOrderDetail.Append(orderDetails.ToString());
            }
            return "The order no: " + orderNo + "\n" +
            client + "\n" + "The sum price of the order: " + orderPrice + "\n" + everyOrderDetail;
        }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && EqualityComparer<Client>.Default.Equals(client, order.client)
            && orderNo == order.orderNo && EqualityComparer<List<OrderDetails>>.Default.Equals(orderDetails, order.orderDetails);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
