using System;
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
            Product product = new Product();
        }

        public Product Product { get; set; }




    }
}
