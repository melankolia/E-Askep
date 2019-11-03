using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Pengkajian_Pasien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Keluar_Click(object sender, EventArgs e)
        {
            Form_Close FC = new Form_Close();
            FC.ShowDialog();
        }

        private void B_Mulai_Click(object sender, EventArgs e)
        {
            Form_Pengkajian FP = new Form_Pengkajian();
            this.Hide();
            //BunifuTransition transition = new bunifu
            //transition.ShowSync(bunifuCards1, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            FP.ShowDialog();
        }
    }
}
