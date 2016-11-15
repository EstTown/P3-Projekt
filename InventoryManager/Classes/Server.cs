using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;
using MySql.Data.MySqlClient;

namespace InventoryManager.Classes
{
    public class Server : IAbstractServer
    {
        public Server(string ip, string userid, string password, string database)
        {
            this.cs = @"server="+ ip +";userid="+ userid +";password="+ password +";database="+ database +"";
        }
        public string cs { get; set; }
    }

    


}
