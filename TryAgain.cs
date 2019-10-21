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
    public partial class TryAgain : Form
    {
        public TryAgain()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Level1Info l = new Level1Info();
            this.Hide();
            l.Show();
        }
    }
}
