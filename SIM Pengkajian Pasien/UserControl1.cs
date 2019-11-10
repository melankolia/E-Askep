using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Pengkajian_Pasien
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (CB_Ambulasi.SelectedIndex == 0 && CB_StatusFungsional.SelectedIndex == 0 && CB_KemampauanMerawatDiri.SelectedIndex == 0 && CB_Intake.SelectedIndex == 0 && CB_TingkatKesadaran.SelectedIndex == 0)
            {
                TB_PPSLevel.Text = "100";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 0 && CB_StatusFungsional.SelectedIndex == 1 && CB_KemampauanMerawatDiri.SelectedIndex == 0 && CB_Intake.SelectedIndex == 0 && CB_TingkatKesadaran.SelectedIndex == 0)
            {
                TB_PPSLevel.Text = "90";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 0 && CB_StatusFungsional.SelectedIndex == 2 && CB_KemampauanMerawatDiri.SelectedIndex == 0 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && CB_TingkatKesadaran.SelectedIndex == 0)
            {
                TB_PPSLevel.Text = "80";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 1 && CB_StatusFungsional.SelectedIndex == 3 && CB_KemampauanMerawatDiri.SelectedIndex == 0 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && CB_TingkatKesadaran.SelectedIndex == 0)
            {
                TB_PPSLevel.Text = "70";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 1 && CB_StatusFungsional.SelectedIndex == 4 && CB_KemampauanMerawatDiri.SelectedIndex == 1 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 1))
            {
                TB_PPSLevel.Text = "60";
                timer1.Enabled = false;
            }
            else if ((CB_Ambulasi.SelectedIndex == 1 || CB_Ambulasi.SelectedIndex == 2) && CB_StatusFungsional.SelectedIndex == 5 && CB_KemampauanMerawatDiri.SelectedIndex == 1 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 1))
            {
                TB_PPSLevel.Text = "50";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 2 && CB_StatusFungsional.SelectedIndex == 6 && CB_KemampauanMerawatDiri.SelectedIndex == 2 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 4 || CB_TingkatKesadaran.SelectedIndex == 5))
            {
                TB_PPSLevel.Text = "40";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 3 && CB_StatusFungsional.SelectedIndex == 7 && CB_KemampauanMerawatDiri.SelectedIndex == 3 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 4 || CB_TingkatKesadaran.SelectedIndex == 5))
            {
                TB_PPSLevel.Text = "30";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 3 && CB_StatusFungsional.SelectedIndex == 8 && CB_KemampauanMerawatDiri.SelectedIndex == 3 && CB_Intake.SelectedIndex == 2 && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 4 || CB_TingkatKesadaran.SelectedIndex == 5))
            {
                TB_PPSLevel.Text = "20";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 3 && CB_StatusFungsional.SelectedIndex == 9 && CB_KemampauanMerawatDiri.SelectedIndex == 3 && CB_Intake.SelectedIndex == 3 && (CB_TingkatKesadaran.SelectedIndex == 6 || CB_TingkatKesadaran.SelectedIndex == 7))
            {
                TB_PPSLevel.Text = "10";
                timer1.Enabled = false;
            }
            else if (CB_Ambulasi.SelectedIndex == 5)
            {
                TB_PPSLevel.Text = "0";
                CB_StatusFungsional.SelectedIndex = 10;
                CB_KemampauanMerawatDiri.SelectedIndex = 4;
                CB_Intake.SelectedIndex = 4;
                CB_TingkatKesadaran.SelectedIndex = 8;
                timer1.Enabled = false;
            }
        }





        private void CB_Ambulasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

        private void CB_StatusFungsional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

        private void CB_KemampauanMerawatDiri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

        private void CB_Intake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

        private void CB_TingkatKesadaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }
    }
}
