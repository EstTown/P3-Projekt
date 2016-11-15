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


            Server server = new Server("172.25.11.109", "admin", "Baesystems2016", "test");
            Fetch fetch = new Fetch(server);
            Push push = new Push(server);

            ConsoleManager.Show();
            Console.WriteLine("Hello m'lady");


        }
    }
}
