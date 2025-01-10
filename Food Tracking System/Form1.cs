using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Net.Http.Headers;

namespace Food_Tracking_System
{
    public partial class Form1 : Form
    {
        application app =  new application();
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHAKMBS\SQLEXPRESS;Initial Catalog=""Food Tracking"";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel8.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username, user_password;
            user_password = txt_password.Text;
            try 
            {
                String querry = "SELECT * FROM login WHERE Username = '"+txt_username.Text+"' AND Password = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtabel = new DataTable();
                sda.Fill(dtabel);

                if (dtabel.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    app.Show();
                    this.Hide();
                }
                else
                {
                    panel6.Visible = true; panel8.Visible=true;
                }
            }
            catch 
            {

            }
            finally { conn.Close(); }

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_username.ForeColor = Color.Black;
                txt_username.Focus();
                panel6.Visible = false;
            }
            catch { }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_password.ForeColor = Color.Black; 
                txt_password.PasswordChar = '*';
                txt_password.Focus(); 
                panel8.Visible = false;
            }
            catch { }
        }
    }
}
