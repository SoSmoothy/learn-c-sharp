using System;

namespace basic_about_c_sharp.basic.Event
{
    class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

    internal class Gasoline
    {
        private decimal _price = 11000;

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price == value) return;
                var oldPrice = _price;
                _price = value;

                var args = new PriceChangedEventArgs(oldPrice, _price);
                PriceChanged?.Invoke(this, args);
            }
        }
    }
}