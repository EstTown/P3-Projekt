﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Interfaces
{
    public interface IAbstractServer
    {
        //Connection string, containing IP, user, password etc.
        string cs { get; set; }
    }
}
