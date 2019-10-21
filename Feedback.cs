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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }
       
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CRS\Documents\EPTDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void playButton_Click(object sender, EventArgs e)
        {
            string ans1 = "";
            string ans2 = "";
            if(radioButton1.Checked == true && radioButton4.Checked == true)
            {
                ans1 = radioButton1.Text;
                ans2 = radioButton4.Text;
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                ans1 = radioButton2.Text;
                ans2 = radioButton3.Text;
            }
            else if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                ans1 = radioButton1.Text;
                ans2 = radioButton3.Text;
            }
            else if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                ans1 = radioButton2.Text;
                ans2 = radioButton4.Text;
            }
            else
            {
                ans1 = "";
                ans2 = "";
            }
            SqlConnection cnn;
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CRS\Documents\EPTDB.mdf;Integrated Security=True;Connect Timeout=30");
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = "Insert Into Feedback(ans1,ans2) values('" + ans1 + "', '" + ans2 + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            cnn.Close();

            Level2Video a2 = new Level2Video();
            this.Hide();
            a2.Show();
               

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
