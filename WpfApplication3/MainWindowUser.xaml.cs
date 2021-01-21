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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindowUser.xaml
    /// </summary>
    public partial class MainWindowUser : Window
    {
        public MainWindowUser()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();  //quit
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 obj = new Window5();
            this.Hide();
            obj.Show();    // view products
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 obj = new Window4();
            this.Hide();
            obj.Show(); //make purchase /buy
        }
    }
}
