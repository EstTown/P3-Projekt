using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;

namespace InventoryManager.Classes
{
    class Product : IProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string desc { get; set; }
        public DateTime date { get; set; }
    }
}
