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
    public partial class AnimacionLevel1Pt1 : Form
    {
        public AnimacionLevel1Pt1()
        {
            InitializeComponent();
        }

        private void AnimacionLevel1Pt1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Level1Info l1 = new Level1Info();
            this.Hide();
            l1.Show();
        }
    }
}
