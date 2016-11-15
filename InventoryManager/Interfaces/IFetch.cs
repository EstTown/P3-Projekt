using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    interface IFetch
    {
        string cs { get; set; } //Connection string

        //People
        List<IVolunteer> AllStaff(string schema, string table);
        List<IVolunteer> Managers(string schema, string table);
        List<IVolunteer> Volunteers(string schema, string table);

        //Products
        List<IProduct> AllProducts(string schema, string table);
        List<IProduct> ProductsInRange(double from, double to, string schema, string table);
    }
}
