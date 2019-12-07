using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SIM_Pengkajian_Pasien
{
    public partial class Form_Pengkajian : Form
    {
        static string regexPattern = "^[0-9]{1,}$";
        static string regexPattern2 = "^[0-2]{1,2}$";
        static string regexPattern3 = "(^[0-9]{1,})(.)([0-9]{1,}$)";
        Regex regex = new Regex(regexPattern);
        Regex newRegex = new Regex(regexPattern2);
        Regex regexComa = new Regex(regexPattern3);

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
        private double baritalIndex()
        {
            double hasil = 0;
                   if (  newRegex.IsMatch(bunifuMaterialTextbox11.Text) && newRegex.IsMatch(bunifuMaterialTextbox13.Text) && newRegex.IsMatch(bunifuMaterialTextbox15.Text)
                      && newRegex.IsMatch(bunifuMaterialTextbox17.Text) && newRegex.IsMatch(bunifuMaterialTextbox19.Text) && newRegex.IsMatch(bunifuMaterialTextbox21.Text)
                      && newRegex.IsMatch(bunifuMaterialTextbox23.Text) && newRegex.IsMatch(bunifuMaterialTextbox25.Text) && newRegex.IsMatch(bunifuMaterialTextbox27.Text)
                      && newRegex.IsMatch(bunifuMaterialTextbox29.Text))
            {
                hasil =   Convert.ToDouble(bunifuMaterialTextbox11.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox13.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox15.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox17.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox19.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox21.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox23.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox25.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox27.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox29.Text);
                return hasil;
            }
            hasil = -1;
            bunifuMaterialTextbox33.Text = "Error";
            return hasil;
        }

        private double baritalIndex2()
        {
            double hasil = 0;
            if (newRegex.IsMatch(bunifuMaterialTextbox12.Text) && newRegex.IsMatch(bunifuMaterialTextbox14.Text) && newRegex.IsMatch(bunifuMaterialTextbox16.Text)
               && newRegex.IsMatch(bunifuMaterialTextbox18.Text) && newRegex.IsMatch(bunifuMaterialTextbox20.Text) && newRegex.IsMatch(bunifuMaterialTextbox22.Text)
               && newRegex.IsMatch(bunifuMaterialTextbox24.Text) && newRegex.IsMatch(bunifuMaterialTextbox26.Text) && newRegex.IsMatch(bunifuMaterialTextbox28.Text)
               && newRegex.IsMatch(bunifuMaterialTextbox30.Text))
            {
                hasil = Convert.ToDouble(bunifuMaterialTextbox12.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox14.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox16.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox18.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox20.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox22.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox24.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox26.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox28.Text)
                        + Convert.ToDouble(bunifuMaterialTextbox30.Text);
                return hasil;
            }
            hasil = -1;
            bunifuMaterialTextbox34.Text = "Error";
            return hasil;
        }

        private double IMT()
        {
            double hasil = 0;
            if (regex.IsMatch(bunifuMaterialTextbox8.Text) && regexComa.IsMatch(bunifuMaterialTextbox9.Text))
            {
                hasil = Math.Round(Convert.ToDouble(bunifuMaterialTextbox8.Text) / (Convert.ToDouble(bunifuMaterialTextbox9.Text) * Convert.ToDouble(bunifuMaterialTextbox9.Text)), 2);
                return hasil;
            }
            hasil = -1.0;
            bunifuMaterialTextbox10.Text = "Error";
            return hasil;
        }
        private double BBIdeal()
        {
            double hasil = 0;
            if (regexComa.IsMatch(bunifuMaterialTextbox9.Text))
            {
                hasil = ((Convert.ToDouble(bunifuMaterialTextbox9.Text) * 100) - 100) - (((Convert.ToDouble(bunifuMaterialTextbox9.Text) * 100) - 100) * 0.10);
                return hasil;
            }
            hasil = -1;
            bunifuMaterialTextbox35.Text = "Error";
            return hasil;
        }
        
        private int TotalInput()
        {
            
            int hasil = 0;
            if (regex.IsMatch(bunifuMaterialTextbox54.Text) && regex.IsMatch(bunifuMaterialTextbox56.Text) && regex.IsMatch(bunifuMaterialTextbox58.Text)
               && regex.IsMatch(bunifuMaterialTextbox60.Text) && regex.IsMatch(bunifuMaterialTextbox62.Text))
            {
                hasil = Convert.ToInt32(bunifuMaterialTextbox54.Text) + Convert.ToInt32(bunifuMaterialTextbox56.Text) + Convert.ToInt32(bunifuMaterialTextbox58.Text)
                      + Convert.ToInt32(bunifuMaterialTextbox60.Text) + Convert.ToInt32(bunifuMaterialTextbox62.Text);
                return hasil;
            }
                hasil = -1;
            bunifuMaterialTextbox52.Text = "Error";
            return hasil;
        }
        private int TotalOutput()
        {

            int hasil = 0;
            if (regex.IsMatch(bunifuMaterialTextbox44.Text) && regex.IsMatch(bunifuMaterialTextbox43.Text) && regex.IsMatch(bunifuMaterialTextbox42.Text))
            {
                hasil = Convert.ToInt32(bunifuMaterialTextbox44.Text) + Convert.ToInt32(bunifuMaterialTextbox43.Text) + Convert.ToInt32(bunifuMaterialTextbox42.Text);
                return hasil;
            }
            hasil = -1;
            bunifuMaterialTextbox38.Text = "Error";
            return hasil;
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
        private void B_Fisik2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }
        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }
        private void B_Sosial_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
        }

        private void B_Psikologis_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }

        private void B_Diagnosis_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 6;
        }
   

        private void B_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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
            else if ((CB_Ambulasi.SelectedIndex == 1 || CB_Ambulasi.SelectedIndex == 2)  && CB_StatusFungsional.SelectedIndex == 5 && CB_KemampauanMerawatDiri.SelectedIndex == 1 && (CB_Intake.SelectedIndex == 0 || CB_Intake.SelectedIndex == 1) && (CB_TingkatKesadaran.SelectedIndex == 0 || CB_TingkatKesadaran.SelectedIndex == 1))
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

        private void B_Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TB_Diastole_OnValueChanged(object sender, EventArgs e)
        {
            double diastole, sistol;
            double MAP;
            if (regex.IsMatch(TB_Diastole.Text) && regex.IsMatch(TB_Sistol.Text))
            {
                diastole = Convert.ToDouble(TB_Diastole.Text);
                sistol = Convert.ToDouble(TB_Sistol.Text);
                MAP = (sistol + (2 * diastole)) / 3;
                TB_MAP.Text = MAP.ToString();
            }

        }

        private void TB_Sistol_OnValueChanged(object sender, EventArgs e)
        {
            double diastole, sistol;
            double MAP;
            if (regex.IsMatch(TB_Diastole.Text) && regex.IsMatch(TB_Sistol.Text))
            {
                diastole = Convert.ToDouble(TB_Diastole.Text);
                sistol = Convert.ToDouble(TB_Sistol.Text);
                MAP = (sistol + (2 * diastole)) / 3;
                TB_MAP.Text = MAP.ToString();
            }


        }

        private void TB_Nadi_OnValueChanged(object sender, EventArgs e)
        {
            double nadi;

            if (regex.IsMatch(TB_Nadi.Text))
            {
                nadi = Convert.ToDouble(TB_Nadi.Text);
                if (nadi <= 60)
                {
                    TB_InterpretasiNadi.Text = "Bradikardia";
                }
                else if (nadi > 60 && nadi <= 100)
                {
                    TB_InterpretasiNadi.Text = "Normal";
                }
                else if (nadi > 100)
                {
                    TB_InterpretasiNadi.Text = "Takikardia";
                }
            }


        }

/*

        private void TB_Sistol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void TB_Diastole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void TB_Nadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void TB_FrekuensiPernapasan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }
        */
        private void TB_FrekuensiPernapasan_OnValueChanged(object sender, EventArgs e)
        {
            double FrekuensiPernapasan;

            if (regex.IsMatch(TB_FrekuensiPernapasan.Text))
            {
                FrekuensiPernapasan = Convert.ToDouble(TB_FrekuensiPernapasan.Text);
                if (FrekuensiPernapasan < 16)
                {
                    TB_InterpretasiFrekuensiPernapasan.Text = "Bradipnea";
                }
                else if (FrekuensiPernapasan >= 16 && FrekuensiPernapasan <= 20)
                {
                    TB_InterpretasiFrekuensiPernapasan.Text = "Normal";
                }
                else if (FrekuensiPernapasan > 20)
                {
                    TB_InterpretasiFrekuensiPernapasan.Text = "Takipnea";
                }
            }

        }

        private void TB_Suhu_OnValueChanged(object sender, EventArgs e)
        {
            double Suhu;
            string regexPatternSuhu = "(^[0-9]{1,})(.)([0-9]{1,}$)";
            Regex regex = new Regex(regexPatternSuhu);
            if (regex.IsMatch(TB_Suhu.Text))
            {
                Suhu = Convert.ToDouble(TB_Suhu.Text);
                if (Suhu < 36)
                {
                    TB_InterpretasiSuhu.Text = "Hipotermia";
                }
                else if (Suhu > 37.5)
                {
                    TB_InterpretasiSuhu.Text = "Hipertermia";
                }
                else if (Suhu <= 37.5 && Suhu >= 36)
                {
                    TB_InterpretasiSuhu.Text = "Normal";
                }
            }
        }


        private void CB_SkalaNyeri_onItemSelected(object sender, EventArgs e)
        {
            switch (CB_SkalaNyeri.selectedIndex)
            {
                case 0:
                    TB_InterpretasiSkalaNyeri.Text = "Tidak nyeri";
                    break;
                case 1:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri ringan";
                    break;
                case 2:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri ringan";
                    break;
                case 3:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri ringan";
                    break;
                case 4:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri sedang";
                    break;
                case 5:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri sedang";
                    break;
                case 6:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri sedang";
                    break;
                case 7:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri berat terkontrol";
                    break;
                case 8:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri berat terkontrol";
                    break;
                case 9:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri berat terkontrol";
                    break;
                case 10:
                    TB_InterpretasiSkalaNyeri.Text = "Nyeri berat tidak terkontrol";
                    break;
            }
        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        // Saat pengkajian

        private void BunifuMaterialTextbox29_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox27_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }


        private void BunifuMaterialTextbox25_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox23_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox21_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox19_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox17_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox15_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox13_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

        private void BunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox31.Text = baritalIndex().ToString();
        }

 

        private void BunifuMaterialTextbox31_OnValueChanged(object sender, EventArgs e)
        {
            int hasil;
            if (bunifuMaterialTextbox31.Text != "" && regex.IsMatch(bunifuMaterialTextbox31.Text))
            {
                hasil = Convert.ToInt32(bunifuMaterialTextbox31.Text);
                if (hasil == -1)
                {
                    bunifuMaterialTextbox33.Text = "Error";
                }
                else if(hasil == 20)
                {
                    bunifuMaterialTextbox33.Text = "Mandiri";

                }
                else if (hasil >= 0 && hasil <= 4)
                {
                    bunifuMaterialTextbox33.Text = "Total";
                }
                else if (hasil >= 5 && hasil <= 8)
                {
                    bunifuMaterialTextbox33.Text = "Berat";
                }
                else if (hasil >= 9 && hasil <= 11)
                {
                    bunifuMaterialTextbox33.Text = "Sedang";
                }
                else if (hasil >= 12 && hasil <= 19)
                {
                    bunifuMaterialTextbox33.Text =  "Ringan";
                }
                else
                {
                    bunifuMaterialTextbox34.Text = "Error";
                }
                
            }
        }
        // saat pulang
        private void BunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }

        private void BunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }

        private void BunifuMaterialTextbox16_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox18_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }

        private void BunifuMaterialTextbox20_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox22_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox24_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox26_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox28_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox30_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox32.Text = baritalIndex2().ToString();
        }
        private void BunifuMaterialTextbox32_OnValueChanged(object sender, EventArgs e)
        {
            int hasil;
            if (bunifuMaterialTextbox32.Text != "" && regex.IsMatch(bunifuMaterialTextbox32.Text))
            {
                hasil = Convert.ToInt32(bunifuMaterialTextbox32.Text);
                if (hasil == -1)
                {
                    bunifuMaterialTextbox34.Text = "Error";
                }
                else if (hasil == 20)
                {
                    bunifuMaterialTextbox34.Text = "Mandiri";

                }
                else if (hasil >= 0 && hasil <= 4)
                {
                    bunifuMaterialTextbox34.Text = "Total";
                }
                else if (hasil >= 5 && hasil <= 8)
                {
                    bunifuMaterialTextbox34.Text = "Berat";
                }
                else if (hasil >= 9 && hasil <= 11)
                {
                    bunifuMaterialTextbox34.Text = "Sedang";
                }
                else if (hasil >= 12 && hasil <= 19)
                {
                    bunifuMaterialTextbox34.Text = "Ringan";
                }
                else
                {
                    bunifuMaterialTextbox34.Text = "Error";
                }
            }
        }

        private void BunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox10.Text = IMT().ToString();
            bunifuMaterialTextbox35.Text = BBIdeal().ToString();
        }

        private void BunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox10.Text = IMT().ToString();
            bunifuMaterialTextbox35.Text = BBIdeal().ToString();
            if (label585.Text == "IWL Normal")
            {
                bunifuMaterialTextbox42.Text = (15 * (Convert.ToInt32(bunifuMaterialTextbox8.Text))).ToString();
                label567.Text = "ml";
            }
            else if (label585.Text == "IWL dengan kenaikan suhu tubuh")
            {
                bunifuMaterialTextbox42.Text = ((240 * ((Convert.ToDouble(TB_Suhu.Text)) - 37.0)) + (15 * (Convert.ToInt32(bunifuMaterialTextbox8.Text)))).ToString();
                label567.Text = "ml / 24 Jam";
            }
        }

        private void Label558_Click(object sender, EventArgs e)
        {

        }

        private void Label567_Click(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox62_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox52.Text = TotalInput().ToString();
        }

        private void BunifuMaterialTextbox60_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox52.Text = TotalInput().ToString();
        }

        private void BunifuMaterialTextbox58_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox52.Text = TotalInput().ToString();
        }

        private void BunifuMaterialTextbox56_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox52.Text = TotalInput().ToString();
        }

        private void BunifuMaterialTextbox54_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox52.Text = TotalInput().ToString();
        }

        private void TB_InterpretasiSuhu_TextChange(object sender, EventArgs e)
        {
            if (TB_InterpretasiSuhu.Text == "Hipertermi")
            {
                label585.Text = "IWL dengan kenaikan suhu tubuh";
            }
            else
            {
                label585.Text = "IWL Normal";
            }
            
        }

        private void BunifuMaterialTextbox44_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox38.Text = TotalOutput().ToString();
        }

        private void BunifuMaterialTextbox43_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox38.Text = TotalOutput().ToString();
        }

        private void BunifuMaterialTextbox42_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox38.Text = TotalOutput().ToString();
        }

        private int totalBalanceCairan()
        {
            int hasil;
            if (regex.IsMatch(bunifuMaterialTextbox52.Text) && regex.IsMatch(bunifuMaterialTextbox38.Text))
            {
                hasil = Convert.ToInt32(bunifuMaterialTextbox52.Text) - Convert.ToInt32(bunifuMaterialTextbox38.Text);
                return hasil;
            }
            hasil = -1;
            
            return hasil;
        }

        private void BunifuMaterialTextbox52_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox40.Text = totalBalanceCairan().ToString();
        }

        private void BunifuMaterialTextbox38_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox40.Text = totalBalanceCairan().ToString();
        }

        private void Label616_Click(object sender, EventArgs e)
        {

        }



        private void Label634_Click(object sender, EventArgs e)
        {

        }

        private void BunifuSeparator47_Load(object sender, EventArgs e)
        {

        }

        private void BunifuCheckBox336_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox336.Checked == true)
            {
                bunifuMaterialTextbox47.Enabled = true;
                bunifuMaterialTextbox47.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox47.Enabled = false;
                bunifuMaterialTextbox47.Visible = false;
            }
        }

        private void BunifuCheckBox337_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox337.Checked == true)
            {
                bunifuMaterialTextbox48.Enabled = true;
                bunifuMaterialTextbox48.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox48.Enabled = false;
                bunifuMaterialTextbox48.Visible = false;
            }
        }

        private void BunifuCheckBox338_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox338.Checked == true)
            {
                bunifuMaterialTextbox49.Enabled = true;
                bunifuMaterialTextbox49.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox49.Enabled = false;
                bunifuMaterialTextbox49.Visible = false;
            }
        }
        private void BunifuCheckBox339_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox339.Checked == true)
            {
                bunifuMaterialTextbox50.Enabled = true;
                bunifuMaterialTextbox50.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox50.Enabled = false;
                bunifuMaterialTextbox50.Visible = false;
            }
        }
        private void BunifuCheckBox340_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox340.Checked == true)
            {
                bunifuMaterialTextbox51.Enabled = true;
                bunifuMaterialTextbox51.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox51.Enabled = false;
                bunifuMaterialTextbox51.Visible = false;
            }
        }



        private void BunifuCheckBox341_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox341.Checked == true)
            {
                bunifuMaterialTextbox53.Enabled = true;
                bunifuMaterialTextbox53.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox53.Enabled = false;
                bunifuMaterialTextbox53.Visible = false;
            }
        }

        private void BunifuCheckBox342_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox342.Checked == true)
            {
                bunifuMaterialTextbox41.Enabled = true;
                bunifuMaterialTextbox41.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox41.Enabled = false;
                bunifuMaterialTextbox41.Visible = false;
            }
        }
        private void BunifuCheckBox343_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox343.Checked == true)
            {
                bunifuMaterialTextbox45.Enabled = true;
                bunifuMaterialTextbox45.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox45.Enabled = false;
                bunifuMaterialTextbox45.Visible = false;
            }
        }


        private void BunifuCheckBox344_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox344.Checked == true)
            {
                bunifuMaterialTextbox46.Enabled = true;
                bunifuMaterialTextbox46.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox46.Enabled = false;
                bunifuMaterialTextbox46.Visible = false;
            }
        }
        private void BunifuCheckBox345_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox345.Checked == true)
            {
                bunifuMaterialTextbox55.Enabled = true;
                bunifuMaterialTextbox55.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox55.Enabled = false;
                bunifuMaterialTextbox55.Visible = false;
            }
        }
        private void BunifuCheckBox346_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox346.Checked == true)
            {
                bunifuMaterialTextbox57.Enabled = true;
                bunifuMaterialTextbox57.Visible = true;
            }
            else
            {
                bunifuMaterialTextbox57.Enabled = false;
                bunifuMaterialTextbox57.Visible = false;
            }
        }


        int animasi = 0;
        int lox = 289;
        int i = 10;
        string penampungan = "";
        string idNameCB = "";
        /* private void buatLabelHeader(string Header)
        {
            Label lebelbaru = new Label();
            lebelbaru.Name = Header;
            lebelbaru.Text = Header;

            lebelbaru.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lebelbaru.ForeColor = Color.White;
            lebelbaru.AutoSize = true;
            lebelbaru.Size = new Size(98, 34);
            lebelbaru.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel2.Controls.Add(lebelbaru);

        }*/

        private void buatLabelDinamis(string NamaPenyakit)
        {
            Label lebelbaru = new Label();
            lox += 20;
            lebelbaru.Name = "lebel" + i.ToString();
            lebelbaru.Text = NamaPenyakit;

            lebelbaru.Font = new Font("Segoe UI", 11);
            lebelbaru.ForeColor = Color.White;
            lebelbaru.AutoSize = true;
            lebelbaru.Size = new Size(98, 34);
            Diagnosa_TabelUtama.Controls.Add(lebelbaru);
            lebelbaru.TextAlign = ContentAlignment.MiddleCenter;
            i += 1;
        }
        private void buatLabelDinamis2(string NamaPenyakit)
        {
            Label lebelbaru = new Label();
            lox += 20;
            lebelbaru.Name = "lebel" + i.ToString();
            lebelbaru.Text = NamaPenyakit;
            lebelbaru.Font = new Font("Segoe UI=", 11);
            lebelbaru.ForeColor = Color.White;
            lebelbaru.AutoSize = true;
            lebelbaru.Size = new Size(98, 34);
            Diagnosa_TabelKedua.Controls.Add(lebelbaru);
            lebelbaru.TextAlign = ContentAlignment.MiddleLeft;
            i += 1;
        }

        private void buatDropdown(string[] Penyebab)
        {
            //var dropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            ComboBox dropdown = new ComboBox();
            for (int i = 0; i < Penyebab.Length; i++)
            {
                dropdown.Items.Add(Penyebab[i]);
            }
            dropdown.Name = "dropdown" + i.ToString();
            dropdown.Dock = DockStyle.Fill;
            dropdown.AutoSize = true;
            //dropdown.Size = new Size(452, 66);
            Diagnosa_TabelUtama.Controls.Add(dropdown);
            dropdown.SelectedIndexChanged += new System.EventHandler(dropdown_SelectedValueChanged);
            dropdown.Location = new Point(3, lox);

        }
        private void dropdown_SelectedValueChanged(object sender, EventArgs e)
        {

            ComboBox combo = (ComboBox)sender;

            if (penampungan.Length > 0 && idNameCB == combo.Name)
            {
                penampungan += ", " + combo.Text.Trim();
                combo.Items.Add(penampungan);
                MessageBox.Show(penampungan);
                penampungan = "";
                combo.SelectedIndex = combo.Items.Count - 1;
            }
            else if (penampungan.Length > 0 && idNameCB != combo.Name)
            {
                penampungan = "";
                penampungan += combo.Text.Trim();
                idNameCB = combo.Name;
            }


            else
            {
                penampungan += combo.Text;
                idNameCB = combo.Name;
            }




        }

        private void buatButton(/*string NamaPenyakit)*/)
        {
            Button btn10 = new Button();
            btn10.Text = "Open";
            //btn10.Name = NamaPenyakit;
            btn10.AutoSize = true;
            btn10.Size = new Size(75, 23);
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn10.Location = new Point(3, lox);
            btn10.Click += new EventHandler(btn_Click);
            Diagnosa_TabelUtama.Controls.Add(btn10);
        }
        private void buatButton2(string NamaPenyakit)
        {
            Button btn10 = new Button();
            btn10.Text = "Open File";
            btn10.ForeColor = Color.White;
            btn10.Name = NamaPenyakit;
            btn10.AutoSize = true;
            btn10.Size = new Size(75, 23);
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn10.Location = new Point(3, lox);
            btn10.Click += new EventHandler(btn_Click);
            btn10.Dock = DockStyle.Fill;
            Diagnosa_TabelKedua.Controls.Add(btn10);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string filename;
            Button boton = (Button)sender;
            MessageBox.Show(boton.Name.ToString());
            switch (boton.Name)
            {
                case "Bersihan Jalan Napas Tidak Efektif":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\BersihanJalanNapasTidakEfektif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Gangguan Penyapihan Ventilator":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanPenyapihanVentilator.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Pertukaran Gas":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanPertukaranGas.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Ventilasi Spontan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanVentilasiSpontan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Sirkulasi Spontan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanSirkulasiSpontan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Penurunan Curah Jantung":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\PenurunanCurahJantung.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Perfusi Perifer Tidak Efektif":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\PerfusiPeriferTidakEfektif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Defisit Nutrisi":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\DefisitNutrisi.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Diare":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Diare.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Hipervolemia":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Hipervolemia.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Hipovolemia":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Hipovolemia.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Inkontinensia Fekal":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\InkontinensiaFekal.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Konstipasi":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Konstipasi.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Retensi Urine":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\RetensiUrine.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Intoleransi Aktivitas":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\IntoleransiAktivitas.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Menelan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanMenelan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Disfungsi Seksual":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\DisfungsiSeksual.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Nyeri Akut":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\NyeriAkut.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Nyeri Kronis":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\NyeriKronis.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Citra Tubuh":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanCitraTubuh.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Identitas Diri":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanIdentitasDiri.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Persepsi Sensori":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanPersepsiSensori.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Keputusasaan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Keputusasaan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Ketidakberdayaan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Ketidakberdayaan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Koping Defensif": 
                    filename = Directory.GetCurrentDirectory() + @"\Resources\KopingDefensif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Koping Komunitas Tidak Efektif":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\KopingKomunitasTidakEfektif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Penurunan Koping Keluarga":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\PenurunanKopingKeluarga.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Pemeliharaan Kesehatan Tidak Efektif":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\PemeliharaanKesehatanTidakEfektif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Gangguan Interaksi Sosial":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanInteraksiSosial.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Komunikasi Verbal":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanKomunikasiVerbal.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Proses Keluarga":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanProsesKeluarga.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Isolasi Sosial":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\IsolasiSosial.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Ketegangan Peran Pemberi Asuhan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\KeteganganPeranPemberiAsuhan.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Penampilan Peran Tidak Efektif":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\PenampilanPeranTidakEfektif.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Gangguan Integritas Kulit atau Jaringan":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Gangguanintegritaskulit.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break; 
                case "Hipertermia":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\Hipertemia.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;
                case "Gangguan Eliminasi Urin":
                    filename = Directory.GetCurrentDirectory() + @"\Resources\GangguanEliminasiUrin.pdf";
                    System.Diagnostics.Process.Start(filename);
                    break;


            }
            /* buatLabelHeader("Diagnosis Keperawatan");
            buatLabelHeader("Kreteria Hasil");
            buatLabelHeader("Intervensi");
            */

        }

        private void Diagnosa_ButtonMulai_Click(object sender, EventArgs e)
        {
            Diagnosis_Timer.Enabled = true;
            Diagnosa_ButtonMulai.Enabled = false;
            Diagnosa_TabelUtama.Visible = true;
            Diagnosa_ButtonMulai.Visible = false;
            Diagnosa_ButtonReset.Visible = true;

            // Klasifikasi 
            double BersihanJalanNapasTidakEfektif = Math.Round((convertToNumber(bunifuCheckBox82.Checked) + convertToNumber(bunifuCheckBox82.Checked)
                                                      + convertToNumber(bunifuCheckBox72.Checked) + convertToNumber((bunifuCheckBox108.Checked == true || bunifuCheckBox103.Checked == true || bunifuCheckBox104.Checked == true))) / 4.0, 1);
            double GangguanPenyapihanVentilator = Math.Round((convertToNumber((TB_InterpretasiFrekuensiPernapasan.Text == "Takipnea")) + convertToNumber(bunifuCheckBox114.Checked)
                                                    + convertToNumber(bunifuCheckBox106.Checked) + convertToNumber(bunifuCheckBox117.Checked) + convertToNumber(bunifuCheckBox270.Checked)
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox41.Text) > 7.42 || Convert.ToDouble(bunifuMaterialTextbox41.Text) < 7.38))) / 6.0, 1);
            double GangguanPertukaranGas = Math.Round((convertToNumber(bunifuCheckBox118.Checked)
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox55.Text)) < 38 || (Convert.ToDouble(bunifuMaterialTextbox55.Text) > 42))
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox46.Text) < 75))
                                                    + convertToNumber(TB_InterpretasiNadi.Text == "Takikardia")
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox41.Text) > 7.42 || Convert.ToDouble(bunifuMaterialTextbox41.Text) < 7.38))
                                                    + convertToNumber((bunifuCheckBox108.Checked == true || bunifuCheckBox103.Checked == true || bunifuCheckBox104.Checked == true))
                                                    ) / 6.0, 1);
            double GangguanVentilasiSpontan = Math.Round((convertToNumber(bunifuCheckBox118.Checked)
                                                    + convertToNumber(bunifuCheckBox114.Checked)
                                                    + convertToNumber(bunifuCheckBox440.Checked)
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox55.Text) > 42))
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox46.Text) < 75))
                                                    + convertToNumber((Convert.ToDouble(bunifuMaterialTextbox57.Text) < 94))
                                                    ) /6.0, 1);
            double GangguanSirkulasiSpontan = Math.Round((convertToNumber(  (Convert.ToDouble(TB_Nadi.Text) < 50)  || Convert.ToDouble(TB_Nadi.Text) > 150 )
                                                    + convertToNumber((Convert.ToDouble(TB_Sistol.Text) < 60) || Convert.ToDouble(TB_Sistol.Text) > 200)
                                                    + convertToNumber((Convert.ToDouble(TB_FrekuensiPernapasan.Text) < 6) || Convert.ToDouble(TB_FrekuensiPernapasan.Text) > 30)
                                                    + convertToNumber((bunifuCheckBox170.Checked == true || bunifuCheckBox173.Checked == true || bunifuCheckBox174.Checked == true))
                                                    ) / 4.0, 1);
            double PenurunanCurahJantung = Math.Round((convertToNumber(bunifuCheckBox126.Checked)
                                                    + convertToNumber(bunifuCheckBox121.Checked)
                                                    + convertToNumber(bunifuCheckBox118.Checked)
                                                    + convertToNumber(bunifuCheckBox119.Checked)
                                                    + convertToNumber(bunifuCheckBox122.Checked)
                                                    + convertToNumber(bunifuCheckBox82.Checked)
                                                    + convertToNumber((TB_InterpretasiNadi.Text == "Bradikardia" || TB_InterpretasiNadi.Text == "Takikardia"))
                                                    + convertToNumber((bunifuCheckBox139.Checked == true || bunifuCheckBox142.Checked == true))
                                                    + convertToNumber(bunifuCheckBox55.Checked)
                                                    + convertToNumber((bunifuCheckBox168.Checked == true || bunifuCheckBox167.Checked == true))
                                                    + convertToNumber(bunifuCheckBox217.Checked)
                                                    + convertToNumber(CB_NadiTerabaLemah.Checked)
                                                    + convertToNumber(bunifuCheckBox137.Checked)
                                                    + convertToNumber(bunifuCheckBox294.Checked)
                                                    + convertToNumber((bunifuCheckBox489.Checked == true || bunifuCheckBox471.Checked == true))
                                                    + convertToNumber(bunifuCheckBox437.Checked)
                                                    + convertToNumber(bunifuCheckBox136.Checked)
                                                    ) / 17.0, 1);
            double PerfusiPeriferTidakEfektif = Math.Round((convertToNumber(bunifuCheckBox137.Checked)
                                                    + convertToNumber(CB_NadiTerabaLemah.Checked)
                                                    + convertToNumber(bunifuCheckBox276.Checked)
                                                    + convertToNumber(bunifuCheckBox269.Checked)
                                                    + convertToNumber(bunifuCheckBox471.Checked)
                                                    ) / 5.0, 1);
            double DefisitNutrisi = convertToNumber((Convert.ToDouble(bunifuMaterialTextbox35.Text) - (Convert.ToDouble(bunifuMaterialTextbox35.Text) * 0.1)) > Convert.ToDouble(bunifuMaterialTextbox8.Text));
            double Diare = Math.Round((convertToNumber(bunifuCheckBox312.Checked)
                                      + convertToNumber(bunifuCheckBox308.Checked)
                                      ) / 1.0, 1);
            double Hipervolemia = Math.Round((convertToNumber(bunifuCheckBox122.Checked)
                                       + convertToNumber(bunifuCheckBox118.Checked)
                                       + convertToNumber(bunifuCheckBox119.Checked)
                                       + convertToNumber((bunifuCheckBox245.Checked == true || bunifuCheckBox243.Checked == true))
                                       + convertToNumber(bunifuCheckBox223.Checked)
                                       + convertToNumber((bunifuCheckBox55.Checked == true || bunifuCheckBox168.Checked == true))
                                      ) /6.0, 1);
            double Hipovolemia = Math.Round((convertToNumber((Convert.ToDouble(TB_Nadi.Text) > 100))
                                       + convertToNumber(CB_NadiTerabaLemah.Checked)
                                       + convertToNumber(bunifuCheckBox473.Checked)
                                       + convertToNumber(bunifuCheckBox269.Checked)
                                       + convertToNumber(bunifuCheckBox275.Checked)
                                       + convertToNumber(bunifuCheckBox302.Checked)
                                      ) /6.0, 1);
            double InkontinensiaFekal = Math.Round((convertToNumber(bunifuCheckBox332.Checked)
                                       + convertToNumber(bunifuCheckBox330.Checked)
                                       + convertToNumber(bunifuCheckBox311.Checked)
                                        ) / 3.0, 1);
            double Konstipasi = Math.Round((convertToNumber(bunifuCheckBox313.Checked)
                                        + convertToNumber(bunifuCheckBox315.Checked)
                                        + convertToNumber(bunifuCheckBox301.Checked)
                                        + convertToNumber((bunifuTextBox7.Text == "Hipoaktif"))
                                        ) / 4.0, 1);
            double RetensiUrine = Math.Round((convertToNumber(bunifuCheckBox329.Checked)
                                        + convertToNumber((bunifuCheckBox296.Checked == true || bunifuCheckBox307.Checked == true))
                                        + convertToNumber(bunifuCheckBox305.Checked)
                                        ) /2.0, 1);
            double IntoleransiAktivitas = Math.Round((convertToNumber(bunifuCheckBox253.Checked)
                                        + convertToNumber(bunifuCheckBox256.Checked)
                                        ) /2.0, 1);
            double GangguanMenelan = Math.Round((convertToNumber(bunifuCheckBox241.Checked)
                                        + convertToNumber(bunifuCheckBox216.Checked)
                                        + convertToNumber(bunifuCheckBox221.Checked)
                                        + convertToNumber(bunifuCheckBox474.Checked)
                                        + convertToNumber(bunifuCheckBox475.Checked)
                                        ) /5.0, 1);
            double DisfungsiSeksual = Math.Round((convertToNumber(bunifuCheckBox463.Checked)
                                        + convertToNumber(bunifuCheckBox464.Checked)
                                        + convertToNumber(bunifuCheckBox465.Checked)
                                        + convertToNumber(bunifuCheckBox466.Checked)
                                        + convertToNumber(bunifuCheckBox467.Checked)
                                        + convertToNumber(bunifuCheckBox468.Checked)
                                        + convertToNumber(bunifuCheckBox469.Checked)
                                        ) /7.0,1);
            double NyeriAkut = Math.Round((convertToNumber(bunifuCheckBox258.Checked)
                                        + convertToNumber(bunifuCheckBox23.Checked)
                                        + convertToNumber((bunifuCheckBox191.Checked == true || bunifuCheckBox179.Checked == true))
                                        + convertToNumber(bunifuCheckBox203.Checked)
                                        + convertToNumber((Convert.ToDouble(TB_Nadi.Text) > 100))
                                        + convertToNumber(bunifuCheckBox201.Checked)
                                        ) / 6.0, 1);
            double NyeriKronis = Math.Round((convertToNumber(bunifuCheckBox258.Checked)
                                        + convertToNumber(bunifuCheckBox264.Checked)
                                        + convertToNumber(bunifuCheckBox23.Checked)
                                        + convertToNumber(bunifuCheckBox203.Checked)
                                        + convertToNumber(bunifuCheckBox190.Checked)
                                        ) /5.0, 1);
            double GangguanCitraTubuh = Math.Round((convertToNumber(bunifuCheckBox353.Checked)
                                        + convertToNumber(bunifuCheckBox248.Checked)
                                        + convertToNumber(bunifuCheckBox254.Checked)
                                        ) / 2.0, 1);
            double GangguanIdentitasDiri = Math.Round((convertToNumber(bunifuCheckBox348.Checked)
                                        + convertToNumber(bunifuCheckBox347.Checked)
                                        + convertToNumber(bunifuCheckBox354.Checked)
                                        + convertToNumber(bunifuCheckBox409.Checked)
                                        + convertToNumber(bunifuCheckBox408.Checked)
                                        + convertToNumber(bunifuCheckBox407.Checked)
                                        + convertToNumber(bunifuCheckBox406.Checked)
                                        ) / 7.0, 1);
            double GangguanPersepsiSensori = Math.Round((convertToNumber(bunifuCheckBox355.Checked)
                                        + convertToNumber(bunifuCheckBox356.Checked)
                                        + convertToNumber(bunifuCheckBox405.Checked)
                                        + convertToNumber(bunifuCheckBox404.Checked)
                                        + convertToNumber(bunifuCheckBox403.Checked)
                                        ) / 5.0, 1);
            double Keputusasaan = Math.Round((convertToNumber(bunifuCheckBox357.Checked)
                                        + convertToNumber(bunifuCheckBox402.Checked)
                                        ) / 1.0, 1);
            double Ketidakberdayaan = Math.Round((convertToNumber(bunifuCheckBox358.Checked)
                                        + convertToNumber(bunifuCheckBox396.Checked)
                                        ) / 1.0, 1);
            double KopingDefensif = Math.Round((convertToNumber(bunifuCheckBox364.Checked)
                                        + convertToNumber(bunifuCheckBox365.Checked)
                                        + convertToNumber(bunifuCheckBox366.Checked)
                                        + convertToNumber(bunifuCheckBox367.Checked)
                                        + convertToNumber(bunifuCheckBox393.Checked)
                                        ) / 5.0, 1);
            double KopingKomunitasTidakEfektif = Math.Round((convertToNumber(bunifuCheckBox459.Checked)
                                                + convertToNumber(bunifuCheckBox515.Checked)
                                                + convertToNumber(bunifuCheckBox514.Checked)
                                                + convertToNumber(bunifuCheckBox513.Checked)
                                                ) / 4.0, 1);
            double PenurunanKopingKeluarga = Math.Round((convertToNumber(bunifuCheckBox457.Checked)
                                    + convertToNumber(bunifuCheckBox509.Checked)
                                    + convertToNumber(bunifuCheckBox508.Checked)
                                    ) / 2.0, 1);
            double PemeliharaanKesehatanTidakEfektif = Math.Round((convertToNumber(bunifuCheckBox369.Checked)
                                    + convertToNumber(bunifuCheckBox370.Checked)
                                    + convertToNumber(bunifuCheckBox387.Checked)
                                    + convertToNumber(bunifuCheckBox386.Checked)
                                    ) / 4.0, 1);
            double GangguanInteraksiSosial = Math.Round((convertToNumber(bunifuCheckBox456.Checked)
                                    + convertToNumber(bunifuCheckBox455.Checked)
                                    + convertToNumber(bunifuCheckBox507.Checked)
                                    + convertToNumber(bunifuCheckBox506.Checked)
                                    ) / 4.0, 1);
            double GangguanKomunikasiVerbal = Math.Round((convertToNumber(bunifuCheckBox383.Checked)
                                    + convertToNumber(bunifuCheckBox419.Checked)
                                    ) / 2.0, 1);
            double GangguanProsesKeluarga = Math.Round((convertToNumber(bunifuCheckBox498.Checked)
                                    + convertToNumber(bunifuCheckBox497.Checked)
                                    ) / 2.0, 1);
            double IsolasiSosial = Math.Round((convertToNumber(bunifuCheckBox453.Checked)
                                    + convertToNumber(bunifuCheckBox452.Checked)
                                    + convertToNumber(bunifuCheckBox516.Checked)
                                    + convertToNumber(bunifuCheckBox496.Checked)
                                    ) /4.0, 1);
            double KeteganganPeranPemberiAsuhan = Math.Round((convertToNumber(bunifuCheckBox448.Checked)
                        + convertToNumber(bunifuCheckBox447.Checked)
                        + convertToNumber(bunifuCheckBox446.Checked)
                        + convertToNumber(bunifuCheckBox485.Checked)
                        ) / 4.0, 1);
            double PenampilanPeranTidakEfektif = Math.Round((convertToNumber(bunifuCheckBox445.Checked)
                           + convertToNumber(bunifuCheckBox444.Checked)
                           + convertToNumber(bunifuCheckBox443.Checked)
                           + convertToNumber(bunifuCheckBox483.Checked)
                           + convertToNumber(bunifuCheckBox482.Checked)
                           + convertToNumber(bunifuCheckBox481.Checked)
                          ) / 6.0, 1);
            double GangguanIntegritasKulitatauJaringan = Math.Round((convertToNumber(bunifuCheckBox289.Checked)
                                                    ) / 1.0, 1);
            double Hipertermia = convertToNumber((Convert.ToDouble(TB_Suhu.Text) > 37.5));
            double GangguanEliminasiUrin = Math.Round((convertToNumber(bunifuCheckBox331.Checked)
                                               + convertToNumber(bunifuCheckBox328.Checked)
                                               + convertToNumber(bunifuCheckBox326.Checked)
                                               + convertToNumber(bunifuCheckBox325.Checked)
                                               + convertToNumber(bunifuCheckBox317.Checked)
                                               + convertToNumber(bunifuCheckBox316.Checked)
                                               + convertToNumber(bunifuCheckBox305.Checked)
                                               + convertToNumber(bunifuCheckBox327.Checked)
                                               + convertToNumber(bunifuCheckBox304.Checked)
                                              ) / 9.0, 1);
            // Codingan
            //MessageBox.Show(BersihanJalanNapasTidakEfektif.ToString());
            MessageBox.Show(GangguanPenyapihanVentilator.ToString());
            if (BersihanJalanNapasTidakEfektif >= 0.80)
            {
                string NamaPenyakit = "Bersihan Jalan Napas Tidak Efektif";
                string[] Penyebab = {   "1)	Fisiologis",
                                        "   Spasme jalan napas",
                                        "   Hiperseksresi jalan napas",
                                        "   Disfungsi neuromuskuler",
                                        "   Benda asing dalam jalan napas",
                                        "   Adanya jalan napas buatan",
                                        "   Sekresi yang tertahan",
                                        "   Hiperplasia dinding jalan napas",
                                        "   Proses infeksi",
                                        "   Respon alergi",
                                        "   Efek agen farmakologis(mis.anastesi)",
                                        "2)	Situasional",
                                        "   Merokok aktif",
                                        "   Merokok pasif",
                                        "   Terpajan polutan"};
                
                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " "+ BersihanJalanNapasTidakEfektif);
                //buatButton(NamaPenyakit);
            }
            if (GangguanPenyapihanVentilator >= 0.80)
            {
                string NamaPenyakit = "Gangguan Penyapihan Ventilator";
                string[] Penyebab = {   "1)	Fisiologis",
                                        "   Hipersekresi jalan napas",
                                        "   Ketidakcukupan energi",
                                        "   Hambatan upaya napas(mis.nyeri saat bernapas, kelemahan otot pernapasan, efek sedagi)",
                                        "2)	Psikologis",
                                        "   Kecemasan",
                                        "   Perasaan tidak berdaya",
                                        "   Kurang terpapar informasi tenlang proses penyapihan",
                                        "   Penurunan motivasi",
                                        "3)	Situasional",
                                        "   Ketidakadekuatan dukungan sosial",
                                        "   Ketidaktepatan kecepatan proses penyapihan",
                                        "   Riwayat kegagalan berulang dalam upaya penyapihan",
                                        "   Riwayat ketergantungan ventilator > 4 hari"};
                
                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanPenyapihanVentilator);
                //buatButton(NamaPenyakit);
            }
            if (GangguanPertukaranGas >= 0.80)
            {
                string NamaPenyakit = "Gangguan Pertukaran Gas";
                string[] Penyebab = {   "Ketidakseimbangan ventilasi-perfusi",
                                        "Perubalian membran alveolus - kapiler"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanPertukaranGas);
            }
            if (GangguanVentilasiSpontan >= 0.80)
            {
                string NamaPenyakit = "Gangguan Ventilasi Spontan";
                string[] Penyebab = {   "Gangguan metabolisme", 
                                        "Kelelahan otot pernapasan"};
              
                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanVentilasiSpontan);
            }
            if (GangguanSirkulasiSpontan >= 0.80)
            {
                string NamaPenyakit = "Gangguan Sirkulasi Spontan";
                string[] Penyebab = {   "Abnormalitas kelistrikan jantung", 
                                        "Abnormatitas struktur jantung",
                                        "Penurunan fungsi ventrikel"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanSirkulasiSpontan);
            }
            if (PenurunanCurahJantung >= 0.80)
            {
                string NamaPenyakit = "Penurunan Curah Jantung";
                string[] Penyebab = {   "Perubahan irama jantung", 
                                        "Perubahan frekuensi jantung",
                                        "Perubahan kontraktilitas",
                                        "Perubahan preload",
                                        "Perubahan afterload"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + PenurunanCurahJantung);
            }
            if (PerfusiPeriferTidakEfektif >= 0.80)
            {
                string NamaPenyakit = "Perfusi Perifer Tidak Efektif";
                string[] Penyebab = {   "Hiperglikernia", 
                                        "Penurunan konsentrasi hemoglobin",
                                        "Peningkatan tekanan darah",
                                        "Kekurangan volume cairan",
                                        "Penurunan aliran arteri daniatau vena",
                                        "Kurang terpapar informasi tentang faktor pemberat",
                                        "Kurang terpapar informasi tentang proses penyakit",
                                        "Kurang aktivitas fisik"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + PerfusiPeriferTidakEfektif);
            }
            if (DefisitNutrisi >= 0.80)
            {
                string NamaPenyakit = "Defisit Nutrisi";
                string[] Penyebab = {   "Ketidakmampuan menelan makanan",
                                        "Ketidakmampuan mencerna makanan",
                                        "Ketidakmampuan mengabsorbsi nutrien",
                                        "Peningkatan kebutuhan metabolisme",
                                        "Faktor ekonomi(mis, finansial tidak mencukupi)",
                                        "Faktor psikologis(mis.stres, keengganan untuk makan)"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + DefisitNutrisi);
            }
            if (Diare >= 0.80)
            {
                string NamaPenyakit = "Diare";
                string[] Penyebab = {   "1)	Fisiologis",
                                            "   lnflamasi gastrointestinal",
                                            "   Iritasi gastrointestinal",
                                            "   Proses infeksi",
                                            "   Malabsorpsi",
                                            "2)	Psikologis",
                                            "   Kecemasan",
                                            "   Tingkat stres tinggi",
                                            "3)	Situasional",
                                            "   Terpapar kontaminan",
                                            "   Terpapar toksin",
                                            "   Penyalahgunaan laksatif",
                                            "   Penyalahgunaan zat",
                                            "   Program pengobatan",
                                            "   Perubahan air dan makanan",
                                            "   Bakteri pada air"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Diare);
            }
            if (Hipervolemia >= 0.80)
            {
                string NamaPenyakit = "Hipervolemia";
                string[] Penyebab = {   "Gangguan mekanisme regulasi", 
                                        "Kelebihan asupan cairan",
                                        "Kelebihan asupan natrium",
                                        "Gangguan aliran balik vena",
                                        "Efek agen farmakologis"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Hipervolemia);
            }
            if (Hipovolemia >= 0.80)
            {
                string NamaPenyakit = "Hipovolemia";
                string[] Penyebab = {   "Kehilangan cairan aktif",
                                        "Kegagalan mekanisme regulasi",
                                        "Peningkatan permeabilitas regulasi",
                                        "Kekurangan intake cairan",
                                        "Evaporasi"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Hipovolemia);
            }
            if (InkontinensiaFekal >= 0.80)
            {
                string NamaPenyakit = "Inkontinensia Fekal";
                string[] Penyebab = {   "Kerusakan susunan saraf motorik bawah",
                                            "Penururtan tonus otot",
                                            "Gangguan kogntif",
                                            "Penyalahgunaan laksatif",
                                            "Kehilangan fungsi pengendalan sfingter rektum",
                                            "Pascaoperasi pullthrough dan penutupan kolosomi",
                                            "Ketidakmampuan mencapai kamar kecil",
                                            "Diare kronis",
                                            "Stres berlebihan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + InkontinensiaFekal);
            }
            if (Konstipasi >= 0.80)
            {
                string NamaPenyakit = "Konstipasi";
                string[] Penyebab = {       "1)	Fisiologis",
                                            "   Penurunan motilitas gastrointestinal",
                                            "   Ketidakadekuatan pertumbuhan gigi",
                                            "   Ketidakcukupan diet",
                                            "   Ketidakcukupan asupan serat",
                                            "   Ketidakcukupan asupan cairan",
                                            "   Aglionik(mis.penyakit Hircsprung)",
                                            "   Kelemahan otot abdomen",
                                            "2)	Psikologis",
                                            "   Konfusi",
                                            "   Depresi",
                                            "   Gangguan emosional",
                                            "3)	Situasional",
                                            "   Perubahan kebiasaan makan",
                                            "   Ketidakadekuatan toileting",
                                            "   Aktivitas fisik harian kurang dari yang dianjurkan",
                                            "   Penyalahgunaan laksatif",
                                            "   Efek agen farmakologis",
                                            "   Ketidakteraturan kebiasaan defekasi",
                                            "   Kebiasaan menahan dorongan defekasi",
                                            "   Perubahan lingkungan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Konstipasi);
            }
            if (RetensiUrine >= 0.80)
            {
                string NamaPenyakit = "Retensi Urine";
                string[] Penyebab = {       "Peningkatan tekanan uretra",
                                                "Kerusakan arkus refleks",
                                                "Blok spingter",
                                                "Disfungsi neurologis(mis.trauma, penyakit saraf)",
                                                "Efek agen farmakologis"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + RetensiUrine);
            }
            if (IntoleransiAktivitas >= 0.80)
            {
                string NamaPenyakit = "Intoleransi Aktivitas";
                string[] Penyebab = {   "Ketidakseimbangan antara suplai dan kebutuhan oksigen",
                                        "Tirah baring Kelemahan",
                                        "Imobilitas",
                                        "Gaya hidup monoton"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " +IntoleransiAktivitas);
            }
            if (GangguanMenelan >= 0.80)
            {
                string NamaPenyakit = "Gangguan Menelan";
                string[] Penyebab = {   "Gangguan serebrovaskular",
                                        "Gangguan saraf kranialis",
                                        "Paralisis serebral",
                                        "Akalasia",
                                        "Abnormalitas laring",
                                        "Abnormalitas orofaring",
                                        "Anomali jalan napas atas",
                                        "Defek anatomik kongenital",
                                        "Defek laring",
                                        "Defek nasal",
                                        "Defek rongga nasofaring",
                                        "Defek trakea",
                                        "Refluk gastroesofagus",
                                        "Obstruksi mekanis",
                                        "Prematuritas"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanMenelan);
            }
            if (DisfungsiSeksual >= 0.80)
            {
                string NamaPenyakit = "Disfungsi Seksual";
                string[] Penyebab = {   "Perubahan fungsi/struktur tubuh",
                                        "Perubahan biopsikososial seksuatitas",
                                        "Ketiadaan model peran",
                                        "Model peran tidak dapat menpengaruhi",
                                        "Kurang privasi",
                                        "Ketiadaan pasangan",
                                        "Kesalahan informasi",
                                        "Kelainan seksual(mis, hubungan penuh kekerasan)",
                                        "Konflik nilai",
                                        "Penganiayaan fisik(mis kekerasan dalam rumah tangga)",
                                        "Kurang terpapar informasi"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + DisfungsiSeksual);
            }
            if (NyeriAkut >= 0.80)
            {
                string NamaPenyakit = "Nyeri Akut";
                string[] Penyebab = {   "Penyebab fisiologis (mis. inflamasi, iskemia, neoplasma)", 
                                            "Agen pencedera kimiawi(mis.terbakar, bahan kimia iritan)",
                                            "Agen pencedera fisik "};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + NyeriAkut);
            }
            if (NyeriKronis >= 0.80)
            {
                string NamaPenyakit = "Nyeri Kronis";
                string[] Penyebab = {   "Kondisi muskuloskeletal kronis",
                                            "Kerusakan sistem saraf",
                                            "Penekanan saraf",
                                            "infiltrasi tumor",
                                            "Ketidakseimbangan neurotransmiter, neuromodulator, dan reseptor",
                                            "Gangguan imunitas(mis.neuropati terkait HIV, virus varicella-zoster)",
                                            "Gangguan fungsi metabolik",
                                            "Riwayat posisi kerja statis",
                                            "Peningkatan indeks massa tubuh",
                                            "Kondisi pasca trauma",
                                            "Tekanan emosional",
                                            "Riwayat penganiayaan(mis.fisik, psikologis, seksual)",
                                            "Riwayat penyalahgunaan obat / zat"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + NyeriKronis);
            }
            if (GangguanCitraTubuh >= 0.80)
            {
                string NamaPenyakit = "Gangguan Citra Tubuh";
                string[] Penyebab = {   "Perubahan struktur/bentuk tubuh",
                                        "Perubahan fungsi tubuh",
                                        "Perubahan fungsi kognitif",
                                        "Ketidaksesuaian budaya, keyakinan atau sistem nilai",
                                        "Transisi perkembangan",
                                        "Gangguan psikososial",
                                        "Efek tindakan/ pengobatan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanCitraTubuh);
            }
            if (GangguanIdentitasDiri >= 0.80)
            {
                string NamaPenyakit = "Gangguan Identitas Diri";
                string[] Penyebab = {   "Gangguan peran sosial",
                                            "Tidak terpenuhinya tugas perkembangan",
                                            "Gangguan neurologis",
                                            "Ketidakadekuatan stimulasi sensori"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanIdentitasDiri);
            }
            if (GangguanPersepsiSensori >= 0.80)
            {
                string NamaPenyakit = "Gangguan Persepsi Sensori";
                string[] Penyebab = {   "Gangguan penglihatan",
                                        "Gangguan pendengaran",
                                        "Gangguan penghiduan",
                                        "Gangguan perabaan",
                                        "Hipoksia serebral",
                                        "Penyalahgunaan zat",
                                        "Usia lanjut",
                                        "Pemajanan toksin lingkungan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanPersepsiSensori);
            }
            if (Keputusasaan >= 0.80)
            {
                string NamaPenyakit = "Keputusasaan";
                string[] Penyebab = {   "Stres jangka panjang",
                                            "Penurunan kondisi fisiologis",
                                            "Kehilangan kepercayaan pada kekuatan spiritual",
                                            "Kehilangan kepercayaan pada nilai-nilai penting",
                                            "Pembatasan aktivitas jangka panjang",
                                            "Pengasingan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Keputusasaan);
            }
            if (Ketidakberdayaan >= 0.80)
            {
                string NamaPenyakit = "Ketidakberdayaan";
                string[] Penyebab = {   "Program perawatan/perigobatan yang kompleks atau jangka panjang",
                                        "Lingkungan tidak rnendukung perawatan/ pengobatan",
                                        "interaksi interpersonal tidak memuaskan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Ketidakberdayaan);
            }
            if (KopingDefensif >= 0.80)
            {
                string NamaPenyakit = "Koping Defensif";
                string[] Penyebab = {   "Konflik antara persepsi diri dan sistem nilai",
                                        "Takut mengalami kegagalan",
                                        "Takut mengalami penghinaan",
                                        "Takut terhadap dampak situasi yang dihadapi",
                                        "Kurangnya rasa percaya kepada orang lain",
                                        "Kurangnya kepercayaan diri",
                                        "Kurangnya dukungan sistem pendukung(support system)",
                                        "Harapan yang tidak realistis"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + KopingDefensif);
            }
            if (KopingKomunitasTidakEfektif >= 0.80)
            {
                string NamaPenyakit = "Koping Komunitas Tidak Efektif";
                string[] Penyebab = {   "Paparan bencana (alam atau buatan manusia)",
                                        "Riwayat bencana(alam atau buatan manusia)",
                                        "Ketidakadekuatan sumber daya untuk pemecahan masalah",
                                        "Ketidakcukupan sumber daya masyarakat(mis.istirahat, rekreasi, dukungan sosial)",
                                        "Tidak adanya sistem masyarakat"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + KopingKomunitasTidakEfektif);
            }
            
            if (PenurunanKopingKeluarga >= 0.80)
            {
                string NamaPenyakit = "Penurunan Koping Keluarga";
                string[] Penyebab = {   "Situasi penyerta yang mempengaruhi orang terdekat",
                                        "Krisis perkembangan yang dihadapi orang terdekat",
                                        "Kelelahan orang terdekat dalam memberikan dukungan",
                                        "Disorganisasi keluarga",
                                        "Perubahan peran keluarga",
                                        "Tidak tersedianya informasi bagi orang terdekat",
                                        "Kurangnya saling mendukung",
                                        "Tidak cukupnya dukungan yang diberikan klien pada orang terdekat",
                                        "Orang terdekat kurang terpapar informasi Salahnya / tidak pahamnya informasi yang didapatkan orang terdekat",
                                        "Orang terdekat terlalu fokus pada kondisi di luar keluarga",
                                        "Penyakit kronis yang menghasilkan kemampuan dukungan orang terdekat",
                                        "Krisis situasional yang dialami orang terdekat"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + PenurunanKopingKeluarga);
            }
            if (PemeliharaanKesehatanTidakEfektif >= 0.80)
            {
                string NamaPenyakit = "Pemeliharaan Kesehatan Tidak Efektif";
                string[] Penyebab = {   "Disabilitas (mis. Penurunan daya ingat, defisit sensorik/motorik)",
                                            "Efek samping program perawatan/ pengobatan",
                                            "Beban pembiayaan program perawatan/ pengobatan",
                                            "Lingkungan tidak teraupetik",
                                            "Program terapi  kompleks dan/ atau lama",
                                            "Hambatan mengakses pelayanan kesehatan(mis.Gangguan mobilisasi, masalah transportasi)",
                                            "Program terapi tidak ditanggung asuransi",
                                            "Ketidakadekuatann pemahaman"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + PemeliharaanKesehatanTidakEfektif);
            }
            if (GangguanInteraksiSosial >= 0.80)
            {
                string NamaPenyakit = "Gangguan Interaksi Sosial";
                string[] Penyebab = {   "Defesiensi bicara",
                                        "Hambatan perkembangan/ maturasi",
                                        "Ketiadaan orang terdekat",
                                        "Perubahan neurologis(mis.Kelahiran prematur)",
                                        "Disfungsi sistem keluarga",
                                        "Ketidakteraturan atau kekacauan lingkungan",
                                        "Penganiayaan atau pengabaian anak",
                                        "Hubungan orang tua - anak tidak memuaskan",
                                        "Model peran negatif",
                                        "Impulsif",
                                        "Perilaku menentang",
                                        "Perilaku agresif",
                                        "Keenganan berpisah dengan orang terdekat"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanInteraksiSosial);
            }
            if (GangguanKomunikasiVerbal >= 0.80)
            {
                string NamaPenyakit = "Gangguan Interaksi Sosial";
                string[] Penyebab = {   "Penurunan sirkulasi serebral",
                                        "Gangguan neuromuskuler",
                                        "Gangguan pendengaran",
                                        "Gangguan musculoskeletal",
                                        "Kelainan palatum",
                                        "Hambatan fisik(mis.terpasang trakheostomi, intubasi, kritotiroidektomi)",
                                        "Hambatan individu(mis.ketakutan, kecemasan)",
                                        "Hambatan psikologis(mis.gangguan psikotik, gangguan konsep diri).",
                                        "Hambatan lingkungan(mis.ketidakcukupan informasi)"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanKomunikasiVerbal);
            }
            if (GangguanProsesKeluarga >= 0.80)
            {
                string NamaPenyakit = "Gangguan Proses Keluarga";
                string[] Penyebab = {   "Perubahan status kesehatan anggota keluarga",
                                            "Perubahan finansial keluarga",
                                            "Perubahan status sosial keluarga",
                                            "Perubahan interaksi dengan masyarakat",
                                            "Krisis perkembangan",
                                            "Transisi perkembangan",
                                            "Peralihan pengambilan keputusan dalam keluarga",
                                            "Perubahan peran keluarga",
                                            "Krisis situasional",
                                            "Transisi situasional"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanProsesKeluarga);
            }
            if (IsolasiSosial >= 0.80)
            {
                string NamaPenyakit = "Isolasi Sosial";
                string[] Penyebab = {   "Keterlambatan perkembangan",
                                        "Ketidakmampuan menjalani hubungan yang memuasakan",
                                        "Ketidaksesuaian minat dengan tahap perkembangan",
                                        "Ketidaksesuaian nilai-nilai dengan norma",
                                        "Ketidaksesuaian perilaku sosial dengan norma",
                                        "Perubahan penampilan fisik",
                                        "Perubahan status mental",
                                        "Ketidakadekuatan sumber daya personal(mis.disfungsi berduka, pengendalian diri buruk)"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + IsolasiSosial);
            }
            if (KeteganganPeranPemberiAsuhan >= 0.80)
            {
                string NamaPenyakit = "Ketegangan Peran Pemberi Asuhan";
                string[] Penyebab = {   "Beratnya penyakit penerima asuhan",
                                            "Kronisnya penyakit penerima asuhan",
                                            "Pemberi asuhan kurang mendapatkan waktu istirahat dan rekreasi",
                                            "Persaingan komitmen peran pemberi asuhan",
                                            "Ketidakadekuatan lingkungan fisik dalam pemberian asuhan",
                                            "Keluarga atau pemberi asuhan jauh dari kerabat lain",
                                            "Kompleksitas dan jumlah aktivitas pemberi asuhan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + KeteganganPeranPemberiAsuhan);
            }
            
            if (PenampilanPeranTidakEfektif >= 0.80)
            {
                string NamaPenyakit = "Penampilan Peran Tidak Efektif";
                string[] Penyebab = {   "Harapan peran tidak realistis",
                                            "Hambatan fisik",
                                            "Harga diri rendah",
                                            "Perubahan citra tubuh",
                                            "Ketidakadekuaan sistem pendukung(support system)",
                                            "Stress",
                                            "Perubahan peran",
                                            "Faktor ekonomi"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + PenampilanPeranTidakEfektif);
            }
            if (GangguanIntegritasKulitatauJaringan >= 0.80)
            {
                string NamaPenyakit = "Gangguan Integritas Kulit atau Jaringan";
                string[] Penyebab = {   "Perubahan sirkulasi",
                                        "Perubahan status nutrisi(kelebihan atau kekurangan)",
                                        "Kekurangan / kelebihan volume cairan",
                                        "Penurunan mobilitas",
                                        "Bahan kimia iritatif",
                                        "Suhu lingkungan yang ekstrem",
                                        "Faktor mekanis(mis.penekanan pada tonjolan tulang, gesekan)",
                                        "Faktor elektris(elektrodiatermi, energi listrik bertegangan tinggi)",
                                        "Efek samping terapi radiasi",
                                        "Kelembaban",
                                        "Proses penuaan",
                                        "Neuropati perifer",
                                        "Perubahan pigmentasi",
                                        "Perubahan hormonal",
                                        "Kurang terpapar informasi tentang upaya mempertahankan/ melindungi integritas jaringan"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanIntegritasKulitatauJaringan);
            }
            if (Hipertermia >= 0.80)
            {
                string NamaPenyakit = "Hipertermia";
                string[] Penyebab = {   "Dehidrasi",
                                            "Terpapar lingkungan panas",
                                            "Proses penyakit(mis.infeksi, kanker)",
                                            "Ketidaksesuaian pakaian dengan suhu lingkungan",
                                            "Peningkatan laju metabolism",
                                            "Respon trauma",
                                            "Aktivitas berlebihan",
                                            "Penggunaan inkubator"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + Hipertermia);
            }
            if (GangguanEliminasiUrin >= 0.80)
            {
                string NamaPenyakit = "Gangguan Eliminasi Urin";
                string[] Penyebab = {   "Disfungsi eliminasi urin"};

                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                MessageBox.Show(NamaPenyakit + " " + GangguanEliminasiUrin);
            }
        }


        private void Diagnosis_Timer_Tick(object sender, EventArgs e)
        {



        }



        private void Diagnosa_ButtonReset_Click(object sender, EventArgs e)
        {
            Diagnosa_TabelUtama.Controls.Clear();
            Diagnosa_TabelUtama.RowCount = 0;
            Diagnosa_TabelKedua.Controls.Clear();
            Diagnosa_TabelKedua.RowCount = 0;
            bunifuCircleProgressbar1.Value = 0;
            animasi = 0;
            Diagnosa_ButtonMulai.Enabled = true;
            Diagnosa_ButtonMulai.Visible = true;
            Diagnosa_ButtonReset.Visible = false;

        }

        private void TableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Diagnosa_ButtonDiagnosaKeperawatan_Click(object sender, EventArgs e)
        {
            int hitung = 0;
            string DiagnosisPerawatan = "";
            string NamaPenyakit = "";
            Diagnosa_TabelKedua.Visible = true;
            foreach (Control c in Diagnosa_TabelUtama.Controls)
            {
                if (c is Label)
                {
                    Label tb = c as Label;
                    DiagnosisPerawatan += tb.Text;
                    NamaPenyakit = tb.Text;
                    hitung++;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = c as ComboBox;
                    DiagnosisPerawatan += " berhubungan dengan " + cb.Text.Trim();
                    hitung++;
                }
                if (hitung == 2)
                {
                    MessageBox.Show(DiagnosisPerawatan);
                    buatLabelDinamis2(DiagnosisPerawatan);
                    buatButton2(NamaPenyakit);
                    buatButton2(NamaPenyakit);
                    DiagnosisPerawatan = "";
                    hitung = 0;
                }

            }



        }

        private void Diagnosis_Timer_Tick_1(object sender, EventArgs e)
        {
            animasi += 1;
            bunifuCircleProgressbar1.Value = animasi;
            if (bunifuCircleProgressbar1.Value == 100)
            {
                Diagnosis_Timer.Enabled = false;
            }
        }

        private void BunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            double peristaltik;
            
            if (regex.IsMatch(bunifuMaterialTextbox4.Text))
            {
                peristaltik = Convert.ToDouble(bunifuMaterialTextbox4.Text);
                if (peristaltik < 5)
                {
                    bunifuTextBox7.Text = "Hipoaktif";
                }
                else if (peristaltik > 5 && peristaltik < 30)
                {
                    bunifuTextBox7.Text = "Normal";
                }
                else if (peristaltik >= 30)
                {
                    bunifuTextBox7.Text = "Hiperaktif";
                }

            }

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
