using System;

namespace CommandPatternDemo
{
    public interface Order
    {
        void Execute();
    }

    public class BuyStock : Order
    {
        private Stock bStock;

        public BuyStock(Stock stock)
        {
            bStock = stock;
        }

        public void Execute()
        {
            bStock.Buy();
        }
    }

    public class SellStock : Order
    {
        private Stock sStock;

        public SellStock(Stock stock)
        {
            sStock = stock;
        }

        public void Execute()
        {
            sStock.Sell();
        }
    }
}