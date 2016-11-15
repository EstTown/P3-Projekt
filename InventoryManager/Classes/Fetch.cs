using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Interfaces;
using MySql.Data.MySqlClient;

namespace InventoryManager.Classes
{
    public class Fetch : IFetch
    {
        public Fetch(Server server)
        {
            this.cs = server.cs;
        }

        public string cs { get; set; }


        public List<IVolunteer> AllStaff(string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();


            string sql = "SELECT * FROM " + schema + "." + table;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<IVolunteer> personList = new List<IVolunteer>();

            while (reader.Read())
            {
                IVolunteer tmp = new Volunteer();
                tmp.id = Convert.ToInt32(reader["id"]);
                tmp.name = Convert.ToString(reader["name"]);
                tmp.email = Convert.ToString(reader["email"]);
                tmp.tlf = Convert.ToString(reader["tlf"]);
                tmp.position = Convert.ToInt32(reader["position"]);
                personList.Add(tmp);
            }

            conn.Close();

            return personList;

        }
        
        public List<IVolunteer> Managers(string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "SELECT * FROM " + schema + "." + table + " WHERE position=1";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<IVolunteer> personList = new List<IVolunteer>();

            while (reader.Read())
            {
                IVolunteer tmp = new Volunteer();
                tmp.id = Convert.ToInt32(reader["id"]);
                tmp.name = Convert.ToString(reader["name"]);
                tmp.email = Convert.ToString(reader["email"]);
                tmp.tlf = Convert.ToString(reader["tlf"]);
                tmp.position = Convert.ToInt32(reader["position"]);
                personList.Add(tmp);
            }

            conn.Close();

            return personList;
        }

        public List<IVolunteer> Volunteers(string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "SELECT * FROM " + schema + "." + table + " WHERE position=0";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<IVolunteer> personList = new List<IVolunteer>();

            while (reader.Read())
            {
                IVolunteer tmp = new Volunteer();
                tmp.id = Convert.ToInt32(reader["id"]);
                tmp.name = Convert.ToString(reader["name"]);
                tmp.email = Convert.ToString(reader["email"]);
                tmp.tlf = Convert.ToString(reader["tlf"]);
                tmp.position = Convert.ToInt32(reader["position"]);
                personList.Add(tmp);
            }

            conn.Close();

            return personList;
        }

        public List<IProduct> AllProducts(string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "SELECT * FROM " + schema + "." + table;
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<IProduct> productList = new List<IProduct>();

            while (reader.Read())
            {
                Product tmp = new Product();
                tmp.id = Convert.ToInt32(reader["id"]);
                tmp.name = Convert.ToString(reader["name"]);
                tmp.desc = Convert.ToString(reader["desc"]);
                tmp.date = Convert.ToDateTime(reader["date"]);
                productList.Add(tmp);
            }

            conn.Close();

            return productList;
        }

        public List<IProduct> ProductsInRange(double from, double to, string schema, string table)
        {
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();

            string sql = "SELECT * FROM " + schema + "." + table + " WHERE price BETWEEN " + from + " AND " + to + "";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            List<IProduct> productList = new List<IProduct>();

            while (reader.Read())
            {
                Product tmp = new Product();
                tmp.id = Convert.ToInt32(reader["id"]);
                tmp.name = Convert.ToString(reader["name"]);
                tmp.desc = Convert.ToString(reader["desc"]);
                tmp.date = Convert.ToDateTime(reader["date"]);
                productList.Add(tmp);
            }

            conn.Close();

            return productList;
        }
    }
}
