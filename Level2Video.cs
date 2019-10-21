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
    public partial class Level2Video : Form
    {
        public Level2Video()
        {
            InitializeComponent();
        }

        private void Level2Video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Level2Info l2i = new Level2Info();
            this.Hide();
            l2i.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
