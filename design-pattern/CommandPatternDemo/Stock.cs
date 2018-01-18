using System;

namespace CommandPatternDemo
{
    public class Stock
    {
        private string name;
        private int quantity;

        public string Name{
            get{ return name; }
            set{ name = value; }
        }

        public int Quantity{
            get {return quantity;}
            set {quantity = value;}
        }
        
        public void Buy()
        {
            Console.WriteLine("Stock [ Name: "+name+", Quantity: " + quantity +" ] bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ Name: "+name+", Quantity: " + quantity +" ] sold");
        }
    }
}