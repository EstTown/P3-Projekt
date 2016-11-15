using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    public interface IProduct
    {
        int id { get; set; }
        string name { get; set; }
        decimal price { get; set; }
        string desc { get; set; }
        DateTime date { get; set; }
    }
}
