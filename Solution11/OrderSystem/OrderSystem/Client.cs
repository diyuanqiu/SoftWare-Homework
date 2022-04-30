using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public Client() { }
        public Client(int id, string name)
        {
            this.ClientId = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
