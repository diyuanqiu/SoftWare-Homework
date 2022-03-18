using System;
namespace Solution5{
    class Good{
        public string goodName{ get; set; }
        public double goodPrice{ get; set; }
        public Good(string name,double price){
            this.goodName = name;
            this.goodPrice = price;
        }
        public override string ToString()
        {
            return "Good name: " + goodName + " \n" + "Per good price: " + goodPrice;
        }
    }
}