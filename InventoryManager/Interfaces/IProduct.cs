using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InventoryManager.Interfaces
{
    public interface IProduct
    {
        int id { get; set; }                    //ID
        string name { get; set; }               //Name
        double price { get; set; }             //Price
        string desc { get; set; }               //Description
        DateTime date { get; set; }             //Date where it was added
        bool isMultipleProduct { get; set; }    //Whether or not the product is unique, or contains multiple instances of the same product.
        Bitmap image { get; set; }              //Image of product -- Not required to exist!
    }
}
