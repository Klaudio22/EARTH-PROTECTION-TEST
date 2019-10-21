using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPT
{
    public partial class Level1Info : Form
    {
        public Level1Info()
        {
            InitializeComponent();
        }

        int counter = 0;
        int len = 0;
        string txt;
        private void Level1Info_Load(object sender, EventArgs e)
        {
            NextButton.Visible = false;
            txt = label3.Text;
            len = txt.Length;
            label3.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter=counter+3;
            if (counter>len)
            {
                counter = 0;
                timer1.Stop();
                NextButton.Visible = true;
            }
            else
            label3.Text = txt.Substring(0, counter);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Level1Quiz q = new Level1Quiz();
            this.Hide();
            q.Show();
        }
    }
}
