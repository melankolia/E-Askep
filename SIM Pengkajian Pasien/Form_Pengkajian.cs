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
    public partial class Form_Pengkajian : Form
    {
        
        int leftcontrol = 0;
        public Form_Pengkajian()
        {
            InitializeComponent();
        }

        private int convertToNumber(bool boolValue)
        {
            if (boolValue == true)
            {
                return 1;
            }
            else if (boolValue == false)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Form_Close FC = new Form_Close();
            FC.ShowDialog();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }


        /* private void B_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
                
        } */

        private void B_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


















        /* private void BunifuButton1_Click(object sender, EventArgs e)
{
   double DBD = Math.Round((convertToNumber(CB_Demam.Checked) + convertToNumber(CB_Mual.Checked))/ 2.0 , 2);
   double DB = Math.Round(convertToNumber(CB_Pegal.Checked) + convertToNumber(CB_SakitKepala.Checked) / 2.0, 2);
   if (DBD >= 0.80)
   {
       Label TB = new Label();
       TB.Name = "Tombol" + leftcontrol.ToString();
       TB.Text = "DBD :" + DBD.ToString();
       leftcontrol += 1;
       flowLayoutPanel1.Controls.Add(TB);
   }
   if (DB >= 0.80)
   {
       Label TB = new Label();
       TB.Name = "Tombol" + leftcontrol.ToString();
       TB.Text = "DB :" + DB.ToString() ;
       leftcontrol += 1;
       flowLayoutPanel1.Controls.Add(TB);
   }

}
*/
    }
}
