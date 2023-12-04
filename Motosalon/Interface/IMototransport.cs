using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon.Interface
{
    public interface IMototransport:IComparable<IMototransport>
    {
        string Brand { get; set; }
        string Model {  get; set; }
        int Price { get; set; }
        int Volume { get; set; }
        bool Filter(IMototransport mototransportFrom, IMototransport mototransportTo);

    }
}
