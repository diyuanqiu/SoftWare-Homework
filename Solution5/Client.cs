using System;
namespace Solution5{
    class Client{
        public string clientName{ get; set; }
        public Client(string name){
            this.clientName = name;
        }
        public override string ToString()
        {
            return "Client: " + clientName;
        }
    }
}