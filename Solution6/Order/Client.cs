using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Client
    {
        public string clientName { get; set; }
        public Client() { }
        public Client(string name)
        {
            this.clientName = name;
        }
        public override string ToString()
        {
            return "Client: " + clientName;
        }
    }
}
