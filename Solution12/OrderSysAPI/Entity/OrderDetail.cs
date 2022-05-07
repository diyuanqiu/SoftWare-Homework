using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSysAPI.Entity{
        public class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
        public string GoodId { get; set; }
        public Good Good { get; set; }
        
        public String GoodsName { get => Good!=null? this.Good.Name:""; }

        public double UnitPrice { get => Good != null ? this.Good.Price : 0.0; }
        public string OrderId;
        public OrderDetail() {
            Id = Guid.NewGuid().ToString();
        }
        public OrderDetail(Good good, int quantity)
        {
            this.Good = good;
            this.Quantity = quantity;
        }
        public double orderPrice
        {
            get => Good==null?0.0: Good.Price * Quantity;
        }
        public override string ToString()
        {
            return "ID:" + Id+ "\n" + "    Per good price: " + Good.Price
            + "\n" + "    Ordered good number: " + Quantity + "\n" + "    The good sum price: " + orderPrice + "\n";
        }
        public override bool Equals(object obj)
        {
            OrderDetail detail = obj as OrderDetail;
            return detail != null
            && EqualityComparer<Good>.Default.Equals(Good, detail.Good)
            && Quantity == detail.Quantity && orderPrice == detail.orderPrice;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}