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
using System.Configuration;
using System.Data;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        Connection db = new Connection();  

        public Login()
        {
            InitializeComponent();
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (db.CON)
                {
                    SqlCommand cmd = new SqlCommand("sp_role_login",db.CON);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.CON.Open();
                    cmd.Parameters.AddWithValue("@uname", UserNametxt.Text);
                    cmd.Parameters.AddWithValue("@upass",PasswordTxt.Password);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        rdr.Read();
                        if (rdr[4].ToString() == "Admin")
                        {   
                            MainWindow obj = new MainWindow();
                            obj.Show();
                            this.Hide();
                        }
                        else if (rdr[4].ToString() == "User")
                        {
                            MainWindowUser objUsr = new MainWindowUser();
                            objUsr.Show();
                            this.Hide();
                        }
                      }
                    else
                    {
                        Window6 obj = new Window6();
                        obj.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception EXC)
            {
                MessageBox.Show(EXC.ToString());
            }


        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
