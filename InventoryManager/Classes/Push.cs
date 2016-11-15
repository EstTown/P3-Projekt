using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;
using MySql.Data.MySqlClient;

namespace InventoryManager.Classes
{
    class Push : IPush
    {
        public Push(Server server)
        {
            this.cs = server.cs;
            //this.schema = schema;
            //this.table = table;
        }

        public string cs { get; set; }
        //public string schema { get; set; }
        //public string table { get; set; }

        
        public void addVolunteer(string name, string email, string tlf, DateTime date, int position, string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "INSERT INTO `" + schema + "`.`" + table + "` (`name`, `email`, `tlf`, `dateofbirth`, `position`) VALUES('" + name + "', '" + email + "', '" + tlf + "', '" + date.Year + "-" + date.Month + "-" + date.Day + " 00:00:00', '" + position + "')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteVolunteerByID(int id, string schema)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "DELETE FROM `" + schema + "`.`staff` WHERE `id`='" + id + "';";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void addProduct(string name, double price, string desc, string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "INSERT INTO `" + schema + "`.`" + table + "` (`name`, `price`, `desc`) VALUES('" + name + "', '" + price + "', '" + desc + "')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteProductByID(int id, string schema)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "DELETE FROM `" + schema + "`.`products` WHERE `id`='" + id + "';";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }


    }
}
