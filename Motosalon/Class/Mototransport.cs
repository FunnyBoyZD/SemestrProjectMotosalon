using System;
using System.Collections.Generic;

namespace Motosalon
{
    [Serializable]
    public class Mototransport : IComparable<Mototransport>
    {
        public int Id {  get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<Client> Clients { get; set; }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0 && value < 1000000)
                {
                    price = value;
                }
                else
                {
                    throw new PriceException("Неправильно введена ціна", value);
                }
            }
        }

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 5000)
                {
                    volume = value;
                }
                else
                {
                    throw new VolumeException("Неправильно введено об'єм", value);
                }
            }
        }

        public Mototransport()
        {
            Brand = string.Empty;
            Model = string.Empty;
        }
        public Mototransport(string Brand, string Model, int Price, int Volume)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
            this.Volume = Volume;
        }

        public int CompareTo(Mototransport other)
        {
            return Price.CompareTo(other.Price);
        }

        public bool Filter(Mototransport mototransportFrom, Mototransport mototransportTo)
        {
            if (mototransportFrom.GetType().Name != "Mototransport" && this.GetType() != mototransportFrom.GetType())
            {
                return false;
            }
            if (mototransportFrom.Brand != "" && this.Brand != mototransportFrom.Brand)
            {
                return false;
            }
            if (mototransportFrom.Model != "" && this.Model != mototransportFrom.Model)
            {
                return false;
            }
            if (mototransportFrom.Volume != 0 && mototransportTo.Volume != 0 && (this.Volume < mototransportFrom.Volume || this.Volume > mototransportTo.Volume))
            {
                return false;
            }
            if (mototransportFrom.Volume == 0 && mototransportTo.Volume != 0 && this.Volume > mototransportTo.Volume)
            {
                return false;
            }
            if (mototransportFrom.Volume != 0 && mototransportTo.Volume == 0 && this.Volume < mototransportFrom.Volume)
            {
                return false;
            }
            if (mototransportFrom.Price != 0 && mototransportTo.Price != 0 && (this.Price < mototransportFrom.Price || this.Price > mototransportTo.Price))
            {
                return false;
            }
            if (mototransportFrom.Price == 0 && mototransportTo.Price != 0 && this.Price > mototransportTo.Price)
            {
                return false;
            }
            if (mototransportFrom.Price != 0 && mototransportTo.Price == 0 && this.Price < mototransportFrom.Price)
            {
                return false;
            }
            return true;

        }
    }
}
