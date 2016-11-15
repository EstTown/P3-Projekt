using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    public interface IVolunteer
    {
        int id { get; set; }
        string name { get; set; }
        DateTime dateOfBirth { get; set; }
        string email { get; set; }
        string tlf { get; set; }
        int position { get; set; }
    }
}
