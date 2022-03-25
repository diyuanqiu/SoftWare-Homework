using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderDetails
    {
        public Good orderedGood { get; set; }
        public int orderedNum { get; set; }
        public double orderdedGoodSumPrice
        {
            get
            {
                return orderedGood.goodPrice * orderedNum;
            }
        }
        public OrderDetails() { }
        public OrderDetails(Good orderedGood, int orderedNum)
        {
            this.orderedGood = orderedGood;
            this.orderedNum = orderedNum;
        }
        public override bool Equals(object? obj)
        {
            OrderDetails details = obj as OrderDetails;
            return details != null
            && EqualityComparer<Good>.Default.Equals(orderedGood, details.orderedGood)
            && orderedNum == details.orderedNum && orderdedGoodSumPrice == details.orderdedGoodSumPrice;
        }
        public override string ToString()
        {
            return "  Good name: " + orderedGood.goodName + "\n" + "    Per good price: " + orderedGood.goodPrice
            + "\n" + "    Ordered good number: " + orderedNum + "\n" + "    The good sum price: " + orderdedGoodSumPrice + "\n";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(orderedGood, orderedNum, orderdedGoodSumPrice);
        }
    }
}
