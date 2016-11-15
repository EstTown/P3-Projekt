using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    public interface IAbstractServer
    {
        string cs { get; set; } //Connection string, containing IP, user, password etc.
    }
}
