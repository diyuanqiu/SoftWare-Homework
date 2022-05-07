using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSysAPI.Entity{
        public class Order : IComparable<Order>
    {
        [Key]
        public string Id { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public String ClientName { get => (Client != null) ? Client.Name : ""; }
        public List<OrderDetail> Details { get; set; }
        public Order() {
            Id = Guid.NewGuid().ToString();
            Details = new List<OrderDetail>();
        }
        public Order(string orderId, Client client, List<OrderDetail> details):this() {
            this.Id = orderId;
            this.Client = client;
            this.Details = details;
        }
        public double TotalPrice {
            get => Details.Sum(item => item.orderPrice);
        }

        public override string ToString()
        {
            StringBuilder everyOrderDetail = new StringBuilder();
            foreach (OrderDetail orderDetails in Details)
            {
                everyOrderDetail.Append(orderDetails.ToString());
            }
            return "The order no: " + Id + "\n" + "Client name: " +
            Client + "\n" + "The sum price of the order: " + TotalPrice + "\n" + everyOrderDetail;
        }
        public override bool Equals(object? obj)
        {
            Order order = obj as Order;
            return order != null && EqualityComparer<Client>.Default.Equals(Client, order.Client)
            && Id == order.Id && EqualityComparer<List<OrderDetail>>.Default.Equals(Details, order.Details);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }
    }
}