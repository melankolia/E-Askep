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

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            
            if (CB_Demam.Checked == true && CB_Mual.Checked == true)
            {
                TextBox TB = new TextBox();
                TB.Name = "Tombol" + leftcontrol.ToString();
                TB.Text = "Demam Berdarah Dengue";
                leftcontrol += 1;
                flowLayoutPanel1.Controls.Add(TB);
            }
            if (CB_Pegal.Checked == true && CB_SakitKepala.Checked == true)
            {
                TextBox TB = new TextBox();
                TB.Name = "Tombol" + leftcontrol.ToString();
                TB.Text = "Demam Berdarah";
                leftcontrol += 1;
                flowLayoutPanel1.Controls.Add(TB);
            }

        }
    }
}
