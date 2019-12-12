using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SIM_Pengkajian_Pasien
{
    public partial class FormPasien : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        
        string strfilename;
        public FormPasien()
        {
            InitializeComponent();
        }

        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            string stat = "New";
            bunifuProgressBar1.Value = 0;
            bunifuProgressBar1.Visible = true;

            for (int i = 0; i <= 750; i++)
            {
                bunifuProgressBar1.Value += 1;
            }
            Form_Pengkajian FP = new Form_Pengkajian(strfilename, stat);
            this.Hide();
            FP.ShowDialog();
            this.Close();

        }

        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {
            string stat = "Load";
            openFile.InitialDirectory = Application.StartupPath + "\\Save\\";
            openFile.Filter = "txt files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                bunifuProgressBar1.Value = 0;
                bunifuProgressBar1.Visible = true;

                for (int i = 0; i <= 750; i++)
                {
                    bunifuProgressBar1.Value += 1;
                }
                strfilename = openFile.FileName;
                Form_Pengkajian f2 = new Form_Pengkajian(strfilename, stat);
                this.Hide();
                f2.ShowDialog();
                
                this.Close();
            }
        }
    }
}
