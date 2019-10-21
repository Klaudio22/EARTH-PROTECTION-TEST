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
    public partial class TestYourSkills : Form
    {
        public TestYourSkills()
        {
            InitializeComponent();
        }
        int correctAns = 0;
        int wrongAns = 0;
        private void playButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            if(corrAns1.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            if (corrAns2.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            if (corrAns3.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            if (corrAns4.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (corrAns5.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }
            if(correctAns >=3)
            {
                Level2Video l2v = new Level2Video();
                this.Hide();
                l2v.Show();
            }
            else
            {
                AnimacionLevel1Pt1 a = new AnimacionLevel1Pt1();
                this.Hide();
                a.Show();
            }
        }
    }
}
