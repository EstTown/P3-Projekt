using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    interface IPush
    {
        string cs { get; set; } //Connection string

        //People
        void addVolunteer(string name, string email, string tlf, DateTime date, int position, string schema, string table);
        void deleteVolunteerByID(int id, string schema);

        //Products
        void addProduct(string name, double price, string desc, string schema, string table);
        void deleteProductByID(int id, string schema);

    }
}
