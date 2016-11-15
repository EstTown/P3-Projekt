using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InventoryManager.Classes;
using InventoryManager.Interfaces;

namespace InventoryManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //Defining server configuration, and setting up fetch and push interfaces
            Server server = new Server("172.25.11.109", "admin", "Baesystems2016", "test");
            Fetch fetch = new Fetch(server);
            Push push = new Push(server);


            ConsoleManager.Show();
            //Console.WriteLine("Hello m'lady");

            //List<IVolunteer> list = fetch.AllStaff("prototype", "staff");
            List<IProduct> listprod = fetch.AllProducts("prototype", "products");

            listView.ItemsSource = listprod;

            foreach (var x in listprod)
            {
                Console.WriteLine(x.price);
            }

            /*
            string fuck = "";
            string shit = "";

            foreach (var x in list)
            {
                Console.WriteLine(x.name);
                fuck = fuck + x.name + "\n";
            }

            foreach (var x in listprod)
            {
                shit = shit + x.name + "\n";
            }

            //textBox.Text = fuck;
            
            */
        }
    }
}
