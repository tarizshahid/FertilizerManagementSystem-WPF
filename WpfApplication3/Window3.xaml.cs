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
using System.Data;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Connection db = new Connection();
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            try
            {
                db.CON.Open();
                SqlCommand cmd = new SqlCommand("insert into Fertilizer_Table(company_id,product_name,product_id,product_com_id,product_quantity,company_name,daily_production) values('" + CompID.Text + "','" + ProdName.Text + "','" + ProdID.Text + "','" + PrCompID.Text + "','" + ProQuan.Text + "','" + CompName.Text + "','" + DailyProduction.Text + "')", db.CON);
                cmd.ExecuteNonQuery();
                db.CON.Close();
                MessageBox.Show("successfully inserted");
                db.CON.Close();

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
            finally
            {
                MainWindow obj = new MainWindow();
                this.Hide();
                obj.Show();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
