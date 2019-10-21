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
    public partial class Solutions : Form
    {
        public Solutions()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int userid = 2;

            SqlConnection cnn;
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CRS\Documents\EPTDB.mdf;Integrated Security=True;Connect Timeout=30");
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "Insert Into Ide(ide,u_id) values('" + textBox1.Text + "', '" + userid + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            cnn.Close();

            END ea = new END();
            this.Hide();
            ea.Show();
        }

        private void Solutions_Load(object sender, EventArgs e)
        {

        }
    }
}
