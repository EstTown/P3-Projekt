﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Models;

namespace InventoryManager.ViewModels
{
    class CreateProductViewModel
    {
        public CreateProductViewModel()
        {
            Product product = new Product() {date = DateTime.Now, desc = "Dett er et smart ur some kan..",
                id = 05521, name = "Rolex Ur", price = 99.95};
            this.Product = product;
        }

        public Product Product { get; set; }




    }
}
