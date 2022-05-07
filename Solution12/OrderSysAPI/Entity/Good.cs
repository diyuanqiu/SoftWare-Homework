using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSysAPI.Entity{
    public class Good
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Good() {
            Id = Guid.NewGuid().ToString();
        }
        public Good(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override bool Equals(object? obj)
        {
            var g = obj as Good;
            return g != null && Id == g.Id && Name == g.Name && Price == g.Price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}