using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Good
    {
        public string goodName { get; set; }
        public double goodPrice { get; set; }
        public Good() { }
        public Good(string name, double price)
        {
            this.goodName = name;
            this.goodPrice = price;
        }
        public override string ToString()
        {
            return "Good name: " + goodName + " \n" + "Per good price: " + goodPrice;
        }
    }
}
