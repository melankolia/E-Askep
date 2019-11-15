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
        int animasi = 0;
        private void B_Keluar_Click(object sender, EventArgs e)
        {
            Form_Close FC = new Form_Close();
            FC.ShowDialog();
        }

        private void B_Mulai_Click(object sender, EventArgs e)
        {

            
            bunifuProgressBar1.Value = 0;
            bunifuProgressBar1.Visible = true;

            for (int i = 0; i <= 750; i++)
            {
                bunifuProgressBar1.Value += 1;
            }
            Form_Pengkajian FP = new Form_Pengkajian();
            this.Hide();
            //BunifuTransition transition = new bunifu
            //transition.ShowSync(bunifuCards1, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
            FP.ShowDialog();
        }

  
    }
}
