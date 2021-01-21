using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        Connection db = new Connection();
        public Window5()
        {
            InitializeComponent();
            label1.Content = DateTime.Now;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string Query = "select * from Fertilizer_Table;";
            db.CON.Open();
            SqlCommand MyCommand2 = new SqlCommand(Query, db.CON);
            MyCommand2.ExecuteNonQuery();
            SqlDataAdapter dataadp = new SqlDataAdapter(MyCommand2);
            DataTable dt = new DataTable("Fertilizer_Table");
            dataadp.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            dataadp.Update(dt);
            db.CON.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
