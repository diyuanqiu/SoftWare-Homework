using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Good
    {
        [Key]
        public int GoodId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Good() { }
        public Good(int id, string name, double price)
        {
            this.GoodId = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
