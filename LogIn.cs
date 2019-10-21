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

namespace EPT
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CRS\Documents\EPTDB.mdf;Integrated Security=True;Connect Timeout=30");
            cnn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT u_name,pass FROM Perdorues WHERE u_name='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                GameMenu gm = new GameMenu();
                this.Hide();
                gm.Show();
                cnn.Close();
            }
            else
            {
                LogIn l = new LogIn();
                this.Hide();
                l.Show();
                cnn.Close();
            }

        }
    }
}
