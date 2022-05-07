using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSysAPI.Entity{
    public class Client{
        [Key]
        public string Id{ get; set; }
        public string Name{ get; set; }
        public Client(){
            Id = Guid.NewGuid().ToString();
        }
        public Client(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj) {
            var customer = obj as Client;
            return customer != null &&
            Id == customer.Id &&
            Name == customer.Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}