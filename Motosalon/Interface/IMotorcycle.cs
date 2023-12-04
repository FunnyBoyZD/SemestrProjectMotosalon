using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon.Interface
{
    internal interface IMotorcycle:IMototransport
    {
        string TypeMotorcycle {  get; set; }
    }
}
