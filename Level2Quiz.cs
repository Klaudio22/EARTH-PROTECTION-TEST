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
    public partial class Level2Quiz : Form
    {
        public Level2Quiz()
        {
            InitializeComponent();
        }

        int correctAns = 0;
        int wrongAns = 0;

        private void Level2Quiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            if (corrans1.Checked == true)
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
            tabControl1.SelectTab(2);
            if (corrans2.Checked == true)
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
            tabControl1.SelectTab(3);
            if (corrans3.Checked == true)
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
            if (corrans4.Checked == true)
            {
                correctAns++;
            }
            else
            {
                wrongAns++;
            }

            if (correctAns >= 3)
            {
                Animacion2Level2 a2 = new Animacion2Level2();
                this.Hide();
                a2.Show();
            }
            else
            {
                TryAgain t = new TryAgain();
                this.Hide();
                t.Show();
            }
        }
    }
}
