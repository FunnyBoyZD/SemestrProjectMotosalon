using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon.Interface
{
    public interface IScooter:IMototransport
    {
        string TypeScooter {  get; set; }
    }
}
