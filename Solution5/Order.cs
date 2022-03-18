using System;
using System.Collections.Generic;
using System.Text;
namespace Solution5{
    class Order{
        public Client client{ get; set; }
        public int orderNo{ get; set; }
        public double sumPrice = 0;
        public double orderPrice{ 
            get{
                foreach(OrderDetails orderDetails in orderDetails){
                    sumPrice += orderDetails.orderdedGoodSumPrice;
                }
                return sumPrice;
            }
        }
        public OrderDetails[] orderDetails{ get; set; }
        public Order(Client client,int orderNo,OrderDetails[] orderDetails){
            this.client = client;
            this.orderNo = orderNo;
            this.orderDetails = orderDetails;
        }
        //stringbuilder
        public override string ToString()
        {
            StringBuilder everyOrderDetail = new StringBuilder();
            foreach(OrderDetails orderDetails in orderDetails){
                everyOrderDetail.Append(orderDetails.ToString());
            }
            return "The order no: " + orderNo + "\n" + 
            client + "\n" + "The sum price of the order: " + orderPrice + "\n"+everyOrderDetail;
        }
        public override bool Equals(object? obj)
        {
            Order order = obj as Order;
            return order != null && EqualityComparer<Client>.Default.Equals(client, order.client)
            && orderNo == order.orderNo && EqualityComparer<OrderDetails[]>.Default.Equals(orderDetails, order.orderDetails)
            && sumPrice == order.sumPrice;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(client, orderNo, sumPrice, orderDetails);
        }
    }
}