using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public List<OrderDetail> Details { get; set; }
        public double totalPrice
        {
            get
            {
                return Details.Sum(orderDetail => orderDetail.orderPrice);
            }
            set { }
        }
        public Order() { }
        public Order(int id,Client client, List<OrderDetail> details)
        {
            this.Id = id;
            this.Client = client;
            if(details != null)
            {
                this.Details = details;
            }
        }
        public override string ToString()
        {
            StringBuilder everyOrderDetail = new StringBuilder();
            foreach (OrderDetail orderDetails in Details)
            {
                everyOrderDetail.Append(orderDetails.ToString());
            }
            return "The order no: " + Id + "\n" + "Client name: " +
            Client + "\n" + "The sum price of the order: " + totalPrice + "\n" + everyOrderDetail;
        }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && EqualityComparer<Client>.Default.Equals(Client, order.Client)
            && Id == order.Id && EqualityComparer<List<OrderDetail>>.Default.Equals(Details, order.Details);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
