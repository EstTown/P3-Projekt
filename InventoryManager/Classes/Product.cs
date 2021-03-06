﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;
using System.Drawing;

namespace InventoryManager.Classes
{
    class Product : IProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string desc { get; set; }
        public DateTime date { get; set; }
        public bool isMultipleProduct { get; set; }
        public Bitmap image { get; set; }

        public override string ToString()
        {
            return this.name + this.price;
        }

    }
}
