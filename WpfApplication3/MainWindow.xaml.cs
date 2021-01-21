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
using System.Data;
using System.Data.SqlClient;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connection db = new Connection();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 obj = new Window3();
            this.Hide();
            obj.Show();
  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //view products from DB
            


            Window5 obj = new Window5();
            this.Hide();
            obj.Show();    // bill code
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window3 obj = new Window3();
            this.Hide();
            obj.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
