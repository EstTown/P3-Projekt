using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;

namespace InventoryManager.Classes
{
    class Volunteer : IVolunteer
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string tlf { get; set; }
        public int position { get; set; }
    }
}
