using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int GoodId { get; set; }
        [ForeignKey("GoodId")]
        public Good Good { get; set; }
        public OrderDetail() { }
        public OrderDetail(int id, Good good, int quantity)
        {
            this.Id = id;
            this.Good = good;
            this.Quantity = quantity;
        }
        public double orderPrice
        {
            get { return Good.Price*Quantity; }
            set { }
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
