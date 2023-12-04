using System;

namespace Motosalon
{
    [Serializable]
    public class TempMoto : Mototransport
    {

        public TempMoto(string Brand, string Model, int Price, int Volume):base(Brand, Model, Price, Volume)
        {
        }

        public int CompareTo(TempMoto other)
        {
            return Price.CompareTo(other.Price);
        }

        public bool Filter(TempMoto mototransportFrom, TempMoto mototransportTo)
        {
            if (mototransportFrom.GetType().Name != "TempMoto" && this.GetType() != mototransportFrom.GetType())
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

