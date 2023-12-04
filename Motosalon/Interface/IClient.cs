using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motosalon.Interface
{
    public delegate void OrderCreationHandler(IClient client);
    public interface IClient
    {
        string Name { get; set; }
        string Surname { get; set; }
        string PhoneNumber { get; set; }
        string Comment { get; set; }
        IMototransport BoughtMoto {  get; set; }
        event OrderCreationHandler OnCall;
    }
}
