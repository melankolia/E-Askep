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
        string[] line;
        string strfilename;
        string stats;

        public Form_Pengkajian(string STR_Value, string stat)
        {
            InitializeComponent();
            strfilename = STR_Value;
            stats = stat;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            
   
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            string tempatsave = "";
            for (int i = 0; i < TB_NoMEDREC.Text.Length; i++)
            {
                if (TB_NoMEDREC.Text[i].ToString() == "\\" || TB_NoMEDREC.Text[i].ToString() == "/")
                {
                    tempatsave += "";
                }
                else
                {
                    tempatsave += TB_NoMEDREC.Text[i];
                }

            }
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Save\\" + tempatsave + "[" + TB_NamaPasien.Text + "]" + ".txt");
            tempatsave = "";
            //TABPAGE 1
            sw.WriteLine(bunifuTextBox10.Text);
            sw.WriteLine(TB_NoMEDREC.Text);
            sw.WriteLine(TB_Jam.Text);
            sw.WriteLine(TB_DPJP.Text);
            sw.WriteLine(TB_NamaPasien.Text);
            sw.WriteLine(bunifuTextBox9.Text);
            sw.WriteLine(TB_UsiaPasien.Text);
            sw.WriteLine(CB_AgamaPasien.selectedIndex.ToString());
            sw.WriteLine(CB_PendidikanPasien.selectedIndex.ToString());
            sw.WriteLine(CB_PekerjaanPasien.selectedIndex.ToString());
            sw.WriteLine(CB_StatusPerkawinanPasien.selectedIndex.ToString());
            sw.WriteLine(TB_AlamatPasien.Text);
            sw.WriteLine(TB_NamaKeluarga.Text);
            sw.WriteLine(bunifuTextBox8.Text);
            sw.WriteLine(TB_UsiaKeluarga.Text);
            sw.WriteLine(CB_AgamaKeluarga.selectedIndex.ToString());
            sw.WriteLine(CB_PendidikanKeluarga.selectedIndex.ToString());
            sw.WriteLine(CB_PekerjaanKeluarga.selectedIndex.ToString());
            sw.WriteLine(CB_StatusPerkawinanKeluarga.selectedIndex.ToString());
            sw.WriteLine(TB_AlamatKeluarga.Text);
            sw.WriteLine(bunifuTextBox1.Text);
            sw.WriteLine(bunifuTextBox2.Text);
            sw.WriteLine(bunifuTextBox3.Text);
            sw.WriteLine(bunifuTextBox4.Text);
            sw.WriteLine(CB_Ambulasi.SelectedIndex.ToString());
            sw.WriteLine(CB_StatusFungsional.SelectedIndex.ToString());
            sw.WriteLine(CB_KemampauanMerawatDiri.SelectedIndex.ToString());
            sw.WriteLine(CB_Intake.SelectedIndex.ToString());
            sw.WriteLine(CB_TingkatKesadaran.SelectedIndex.ToString());

            //TABPAGE 2
            sw.WriteLine(TB_Sistol.Text);
            sw.WriteLine(TB_Diastole.Text);
            sw.WriteLine(TB_MAP.Text);
            sw.WriteLine(TB_Nadi.Text);
            sw.WriteLine(TB_InterpretasiNadi.Text);
            sw.WriteLine(CB_NadiTerabaLemah.Checked);
            sw.WriteLine(CB_NadiTerabaKuat.Checked);
            sw.WriteLine(bunifuCheckBox473.Checked);
            sw.WriteLine(bunifuCheckBox472.Checked);
            sw.WriteLine(TB_FrekuensiPernapasan.Text);
            sw.WriteLine(TB_InterpretasiFrekuensiPernapasan.Text);
            sw.WriteLine(TB_Suhu.Text);
            sw.WriteLine(TB_InterpretasiSuhu.Text);
            sw.WriteLine(CB_SkalaNyeri.selectedIndex.ToString());
            sw.WriteLine(TB_InterpretasiSkalaNyeri.Text);
            sw.WriteLine(TB_FrekuensiNyeri.Text);
            sw.WriteLine(TB_DurasiNyeri.Text);
            sw.WriteLine(TB_InterpretasiSuhu.Text);
            sw.WriteLine(TB_LokasiNyeri.Text);
            sw.WriteLine(CB_LamaMerasaNyeri.selectedIndex.ToString());
            sw.WriteLine(bunifuDropdown1.selectedIndex.ToString());
            sw.WriteLine(bunifuCheckBox9.Checked);
            sw.WriteLine(bunifuCheckBox6.Checked);
            sw.WriteLine(bunifuCheckBox2.Checked);
            sw.WriteLine(bunifuCheckBox1.Checked);
            sw.WriteLine(bunifuCheckBox11.Checked);
            sw.WriteLine(bunifuCheckBox10.Checked);
            sw.WriteLine(bunifuCheckBox4.Checked);
            sw.WriteLine(bunifuCheckBox3.Checked);
            sw.WriteLine(bunifuCheckBox13.Checked);
            sw.WriteLine(bunifuCheckBox12.Checked);
            sw.WriteLine(bunifuCheckBox5.Checked);
            sw.WriteLine(bunifuCheckBox7.Checked);
            sw.WriteLine(bunifuCheckBox8.Checked);
            sw.WriteLine(bunifuCheckBox14.Checked);
            sw.WriteLine(bunifuCheckBox16.Checked);
            sw.WriteLine(bunifuCheckBox17.Checked);
            sw.WriteLine(bunifuCheckBox28.Checked);
            sw.WriteLine(bunifuCheckBox29.Checked);
            sw.WriteLine(bunifuCheckBox19.Checked);
            sw.WriteLine(bunifuCheckBox20.Checked);
            sw.WriteLine(bunifuCheckBox30.Checked);
            sw.WriteLine(bunifuCheckBox18.Checked);
            sw.WriteLine(bunifuCheckBox31.Checked);
            sw.WriteLine(bunifuCheckBox22.Checked);
            sw.WriteLine(bunifuCheckBox23.Checked);
            sw.WriteLine(bunifuCheckBox32.Checked);
            sw.WriteLine(bunifuCheckBox33.Checked);
            sw.WriteLine(bunifuCheckBox21.Checked);
            sw.WriteLine(bunifuCheckBox24.Checked);
            sw.WriteLine(bunifuCheckBox25.Checked);
            sw.WriteLine(bunifuCheckBox36.Checked);
            sw.WriteLine(bunifuCheckBox37.Checked);
            sw.WriteLine(bunifuCheckBox34.Checked);
            sw.WriteLine(bunifuCheckBox38.Checked);
            sw.WriteLine(bunifuCheckBox26.Checked);
            sw.WriteLine(bunifuCheckBox27.Checked);
            sw.WriteLine(bunifuCheckBox39.Checked);
            sw.WriteLine(bunifuCheckBox40.Checked);
            sw.WriteLine(bunifuCheckBox41.Checked);
            sw.WriteLine(bunifuCheckBox42.Checked);
            sw.WriteLine(bunifuCheckBox43.Checked);
            sw.WriteLine(bunifuCheckBox44.Checked);
            sw.WriteLine(bunifuCheckBox45.Checked);
            sw.WriteLine(bunifuCheckBox46.Checked);
            sw.WriteLine(bunifuCheckBox47.Checked);
            sw.WriteLine(bunifuCheckBox48.Checked);
            sw.WriteLine(bunifuCheckBox49.Checked);
            sw.WriteLine(bunifuCheckBox50.Checked);
            sw.WriteLine(bunifuCheckBox51.Checked);
            sw.WriteLine(bunifuCheckBox52.Checked);
            sw.WriteLine(bunifuCheckBox53.Checked);
            sw.WriteLine(bunifuCheckBox54.Checked);
            sw.WriteLine(bunifuCheckBox55.Checked);
            sw.WriteLine(bunifuCheckBox56.Checked);
            sw.WriteLine(bunifuCheckBox57.Checked);
            sw.WriteLine(bunifuCheckBox58.Checked);
            sw.WriteLine(bunifuMaterialTextbox1.Text);
            sw.WriteLine(bunifuCheckBox59.Checked);
            sw.WriteLine(bunifuCheckBox60.Checked);
            sw.WriteLine(bunifuCheckBox61.Checked);
            sw.WriteLine(bunifuCheckBox62.Checked);
            sw.WriteLine(bunifuCheckBox63.Checked);
            sw.WriteLine(bunifuCheckBox64.Checked);
            sw.WriteLine(bunifuCheckBox65.Checked);
            sw.WriteLine(bunifuCheckBox66.Checked);
            sw.WriteLine(bunifuCheckBox67.Checked);
            sw.WriteLine(bunifuCheckBox68.Checked);
            sw.WriteLine(bunifuCheckBox69.Checked);
            sw.WriteLine(bunifuCheckBox70.Checked);
            sw.WriteLine(bunifuCheckBox71.Checked);
            sw.WriteLine(bunifuCheckBox75.Checked);
            sw.WriteLine(bunifuCheckBox74.Checked);
            sw.WriteLine(bunifuCheckBox76.Checked);
            sw.WriteLine(bunifuCheckBox78.Checked);
            sw.WriteLine(bunifuCheckBox77.Checked);
            sw.WriteLine(bunifuCheckBox73.Checked);
            sw.WriteLine(bunifuCheckBox81.Checked);
            sw.WriteLine(bunifuCheckBox82.Checked);
            sw.WriteLine(bunifuCheckBox83.Checked);
            sw.WriteLine(bunifuCheckBox72.Checked);
            sw.WriteLine(bunifuMaterialTextbox2.Text);
            sw.WriteLine(bunifuCheckBox79.Checked);
            sw.WriteLine(bunifuCheckBox80.Checked);
            sw.WriteLine(bunifuMaterialTextbox3.Text);
            sw.WriteLine(bunifuTextBox5.Text);
            sw.WriteLine(bunifuCheckBox87.Checked);
            sw.WriteLine(bunifuCheckBox86.Checked);
            sw.WriteLine(bunifuCheckBox88.Checked);
            sw.WriteLine(bunifuCheckBox90.Checked);
            sw.WriteLine(bunifuCheckBox89.Checked);
            sw.WriteLine(bunifuCheckBox85.Checked);
            sw.WriteLine(bunifuCheckBox84.Checked);
            sw.WriteLine(bunifuCheckBox91.Checked);
            sw.WriteLine(bunifuCheckBox93.Checked);
            sw.WriteLine(bunifuCheckBox94.Checked);
            sw.WriteLine(bunifuCheckBox92.Checked);
            sw.WriteLine(bunifuCheckBox95.Checked);
            sw.WriteLine(bunifuCheckBox97.Checked);
            sw.WriteLine(bunifuCheckBox101.Checked);
            sw.WriteLine(bunifuCheckBox100.Checked);
            sw.WriteLine(bunifuCheckBox102.Checked);
            sw.WriteLine(bunifuCheckBox104.Checked);
            sw.WriteLine(bunifuCheckBox103.Checked);
            sw.WriteLine(bunifuCheckBox99.Checked);
            sw.WriteLine(bunifuCheckBox98.Checked);
            sw.WriteLine(bunifuCheckBox105.Checked);
            sw.WriteLine(bunifuCheckBox106.Checked);
            sw.WriteLine(bunifuCheckBox107.Checked);
            sw.WriteLine(bunifuCheckBox108.Checked);
            sw.WriteLine(bunifuCheckBox109.Checked);
            sw.WriteLine(bunifuCheckBox96.Checked);
            sw.WriteLine(bunifuCheckBox110.Checked);
            sw.WriteLine(bunifuCheckBox111.Checked);
            sw.WriteLine(bunifuCheckBox112.Checked);
            sw.WriteLine(bunifuCheckBox113.Checked);
            sw.WriteLine(bunifuCheckBox114.Checked);
            sw.WriteLine(bunifuCheckBox115.Checked);
            sw.WriteLine(bunifuCheckBox116.Checked);
            sw.WriteLine(bunifuCheckBox117.Checked);
            sw.WriteLine(bunifuCheckBox439.Checked);
            sw.WriteLine(bunifuCheckBox440.Checked);
            sw.WriteLine(bunifuCheckBox118.Checked);
            sw.WriteLine(bunifuCheckBox119.Checked);
            sw.WriteLine(bunifuCheckBox120.Checked);
            sw.WriteLine(bunifuCheckBox124.Checked);
            sw.WriteLine(bunifuCheckBox122.Checked);
            sw.WriteLine(bunifuCheckBox125.Checked);
            sw.WriteLine(bunifuCheckBox121.Checked);
            sw.WriteLine(bunifuCheckBox126.Checked);
            sw.WriteLine(bunifuCheckBox127.Checked);
            sw.WriteLine(bunifuCheckBox123.Checked);
            sw.WriteLine(bunifuCheckBox128.Checked);
            sw.WriteLine(bunifuCheckBox129.Checked);
            sw.WriteLine(bunifuCheckBox130.Checked);
            sw.WriteLine(bunifuCheckBox131.Checked);
            sw.WriteLine(bunifuCheckBox132.Checked);
            sw.WriteLine(bunifuCheckBox133.Checked);
            sw.WriteLine(bunifuCheckBox134.Checked);
            sw.WriteLine(bunifuCheckBox135.Checked);
            sw.WriteLine(bunifuCheckBox136.Checked);
            sw.WriteLine(bunifuCheckBox137.Checked);
            sw.WriteLine(bunifuCheckBox138.Checked);
            sw.WriteLine(bunifuCheckBox140.Checked);
            sw.WriteLine(bunifuCheckBox141.Checked);
            sw.WriteLine(bunifuCheckBox436.Checked);
            sw.WriteLine(bunifuCheckBox433.Checked);
            sw.WriteLine(bunifuCheckBox437.Checked);
            sw.WriteLine(bunifuCheckBox438.Checked);
            sw.WriteLine(bunifuMaterialTextbox5.Text);
            sw.WriteLine(bunifuCheckBox139.Checked);
            sw.WriteLine(bunifuCheckBox142.Checked);
            sw.WriteLine(bunifuCheckBox143.Checked);
            sw.WriteLine(bunifuCheckBox144.Checked);
            sw.WriteLine(bunifuCheckBox167.Checked);
            sw.WriteLine(bunifuCheckBox168.Checked);
            sw.WriteLine(bunifuCheckBox165.Checked);
            sw.WriteLine(bunifuCheckBox166.Checked);
            sw.WriteLine(bunifuCheckBox163.Checked);
            sw.WriteLine(bunifuCheckBox164.Checked);
            sw.WriteLine(bunifuCheckBox157.Checked);
            sw.WriteLine(bunifuCheckBox158.Checked);
            sw.WriteLine(bunifuCheckBox161.Checked);
            sw.WriteLine(bunifuCheckBox162.Checked);
            sw.WriteLine(bunifuCheckBox159.Checked);
            sw.WriteLine(bunifuCheckBox160.Checked);
            sw.WriteLine(bunifuCheckBox155.Checked);
            sw.WriteLine(bunifuCheckBox156.Checked);
            sw.WriteLine(bunifuTextBox6.Text);
            sw.WriteLine(bunifuCheckBox15.Checked);

            //TABPAGE 3
            sw.WriteLine(bunifuCheckBox145.Checked);
            sw.WriteLine(bunifuCheckBox146.Checked);
            sw.WriteLine(bunifuCheckBox147.Checked);
            sw.WriteLine(bunifuCheckBox154.Checked);
            sw.WriteLine(bunifuCheckBox169.Checked);
            sw.WriteLine(bunifuCheckBox152.Checked);
            sw.WriteLine(bunifuCheckBox153.Checked);
            sw.WriteLine(bunifuCheckBox170.Checked);
            sw.WriteLine(bunifuCheckBox171.Checked);
            sw.WriteLine(bunifuCheckBox172.Checked);
            sw.WriteLine(bunifuCheckBox173.Checked);
            sw.WriteLine(bunifuCheckBox174.Checked);
            sw.WriteLine(bunifuCheckBox175.Checked);
            sw.WriteLine(bunifuCheckBox176.Checked);
            sw.WriteLine(bunifuCheckBox177.Checked);
            sw.WriteLine(bunifuCheckBox178.Checked);
            sw.WriteLine(bunifuCheckBox179.Checked);
            sw.WriteLine(bunifuCheckBox180.Checked);
            sw.WriteLine(bunifuCheckBox181.Checked);
            sw.WriteLine(bunifuCheckBox190.Checked);
            sw.WriteLine(bunifuCheckBox191.Checked);
            sw.WriteLine(bunifuCheckBox192.Checked);
            sw.WriteLine(bunifuCheckBox207.Checked);
            sw.WriteLine(bunifuCheckBox206.Checked);
            sw.WriteLine(bunifuCheckBox205.Checked);
            sw.WriteLine(bunifuCheckBox204.Checked);
            sw.WriteLine(bunifuCheckBox203.Checked);
            sw.WriteLine(bunifuCheckBox202.Checked);
            sw.WriteLine(bunifuCheckBox201.Checked);
            sw.WriteLine(bunifuCheckBox187.Checked);
            sw.WriteLine(bunifuCheckBox188.Checked);
            sw.WriteLine(bunifuCheckBox185.Checked);
            sw.WriteLine(bunifuCheckBox189.Checked);
            sw.WriteLine(bunifuCheckBox183.Checked);
            sw.WriteLine(bunifuCheckBox184.Checked);
            sw.WriteLine(bunifuCheckBox186.Checked);
            sw.WriteLine(bunifuMaterialTextbox7.Text);
            sw.WriteLine(bunifuMaterialTextbox4.Text);
            sw.WriteLine(bunifuTextBox7.Text);
            sw.WriteLine(bunifuMaterialTextbox8.Text);
            sw.WriteLine(bunifuMaterialTextbox6.Text);
            sw.WriteLine(bunifuMaterialTextbox9.Text);
            sw.WriteLine(bunifuCheckBox194.Checked);
            sw.WriteLine(bunifuCheckBox195.Checked);
            sw.WriteLine(bunifuCheckBox193.Checked);
            sw.WriteLine(bunifuMaterialTextbox10.Text);
            sw.WriteLine(bunifuCheckBox197.Checked);
            sw.WriteLine(bunifuCheckBox198.Checked);
            sw.WriteLine(bunifuCheckBox196.Checked);
            sw.WriteLine(bunifuMaterialTextbox35.Text);
            sw.WriteLine(bunifuCheckBox218.Checked);
            sw.WriteLine(bunifuCheckBox217.Checked);
            sw.WriteLine(bunifuCheckBox216.Checked);
            sw.WriteLine(bunifuCheckBox215.Checked);
            sw.WriteLine(bunifuCheckBox214.Checked);
            sw.WriteLine(bunifuCheckBox213.Checked);
            sw.WriteLine(bunifuCheckBox212.Checked);
            sw.WriteLine(bunifuCheckBox228.Checked);
            sw.WriteLine(bunifuCheckBox227.Checked);
            sw.WriteLine(bunifuCheckBox211.Checked);
            sw.WriteLine(bunifuCheckBox210.Checked);
            sw.WriteLine(bunifuCheckBox209.Checked);
            sw.WriteLine(bunifuCheckBox208.Checked);
            sw.WriteLine(bunifuCheckBox200.Checked);
            sw.WriteLine(bunifuCheckBox199.Checked);
            sw.WriteLine(bunifuCheckBox182.Checked);
            sw.WriteLine(bunifuCheckBox235.Checked);
            sw.WriteLine(bunifuCheckBox234.Checked);
            sw.WriteLine(bunifuCheckBox229.Checked);
            sw.WriteLine(bunifuCheckBox224.Checked);
            sw.WriteLine(bunifuCheckBox223.Checked);
            sw.WriteLine(bunifuCheckBox222.Checked);
            sw.WriteLine(bunifuCheckBox221.Checked);
            sw.WriteLine(bunifuCheckBox220.Checked);
            sw.WriteLine(bunifuCheckBox219.Checked);
            sw.WriteLine(bunifuCheckBox225.Checked);
            sw.WriteLine(bunifuCheckBox474.Checked);
            sw.WriteLine(bunifuCheckBox475.Checked);
            sw.WriteLine(bunifuCheckBox233.Checked);
            sw.WriteLine(bunifuCheckBox232.Checked);
            sw.WriteLine(bunifuCheckBox236.Checked);
            sw.WriteLine(bunifuCheckBox230.Checked);
            sw.WriteLine(bunifuCheckBox231.Checked);
            sw.WriteLine(bunifuCheckBox226.Checked);
            sw.WriteLine(bunifuCheckBox237.Checked);
            sw.WriteLine(bunifuCheckBox238.Checked);
            sw.WriteLine(bunifuCheckBox239.Checked);
            sw.WriteLine(bunifuCheckBox240.Checked);
            sw.WriteLine(bunifuCheckBox241.Checked);
            sw.WriteLine(bunifuCheckBox242.Checked);


            //TABPAGE 4
            sw.WriteLine(bunifuCheckBox249.Checked);
            sw.WriteLine(bunifuCheckBox248.Checked);
            sw.WriteLine(bunifuCheckBox247.Checked);
            sw.WriteLine(bunifuCheckBox246.Checked);
            sw.WriteLine(bunifuCheckBox250.Checked);
            sw.WriteLine(bunifuCheckBox245.Checked);
            sw.WriteLine(bunifuCheckBox244.Checked);
            sw.WriteLine(bunifuCheckBox254.Checked);
            sw.WriteLine(bunifuCheckBox253.Checked);
            sw.WriteLine(bunifuCheckBox252.Checked);
            sw.WriteLine(bunifuCheckBox251.Checked);
            sw.WriteLine(bunifuCheckBox263.Checked);
            sw.WriteLine(bunifuCheckBox264.Checked);
            sw.WriteLine(bunifuCheckBox261.Checked);
            sw.WriteLine(bunifuCheckBox265.Checked);
            sw.WriteLine(bunifuCheckBox257.Checked);
            sw.WriteLine(bunifuCheckBox256.Checked);
            sw.WriteLine(bunifuCheckBox255.Checked);
            sw.WriteLine(bunifuCheckBox258.Checked);
            sw.WriteLine(bunifuCheckBox259.Checked);
            sw.WriteLine(bunifuCheckBox260.Checked);
            sw.WriteLine(bunifuCheckBox262.Checked);
            sw.WriteLine(bunifuCheckBox266.Checked);
            sw.WriteLine(bunifuCheckBox267.Checked);
            sw.WriteLine(bunifuMaterialTextbox11.Text);
            sw.WriteLine(bunifuMaterialTextbox12.Text);
            sw.WriteLine(bunifuMaterialTextbox13.Text);
            sw.WriteLine(bunifuMaterialTextbox14.Text);
            sw.WriteLine(bunifuMaterialTextbox15.Text);
            sw.WriteLine(bunifuMaterialTextbox16.Text);
            sw.WriteLine(bunifuMaterialTextbox17.Text);
            sw.WriteLine(bunifuMaterialTextbox18.Text);
            sw.WriteLine(bunifuMaterialTextbox19.Text);
            sw.WriteLine(bunifuMaterialTextbox20.Text);
            sw.WriteLine(bunifuMaterialTextbox21.Text);
            sw.WriteLine(bunifuMaterialTextbox22.Text);
            sw.WriteLine(bunifuMaterialTextbox23.Text);
            sw.WriteLine(bunifuMaterialTextbox24.Text);
            sw.WriteLine(bunifuMaterialTextbox25.Text);
            sw.WriteLine(bunifuMaterialTextbox26.Text);
            sw.WriteLine(bunifuMaterialTextbox27.Text);
            sw.WriteLine(bunifuMaterialTextbox28.Text);
            sw.WriteLine(bunifuMaterialTextbox29.Text);
            sw.WriteLine(bunifuMaterialTextbox30.Text);
            sw.WriteLine(bunifuMaterialTextbox31.Text);
            sw.WriteLine(bunifuMaterialTextbox32.Text);
            sw.WriteLine(bunifuMaterialTextbox33.Text);
            sw.WriteLine(bunifuMaterialTextbox34.Text);
            sw.WriteLine(bunifuCheckBox268.Checked);
            sw.WriteLine(bunifuCheckBox269.Checked);
            sw.WriteLine(bunifuCheckBox274.Checked);
            sw.WriteLine(bunifuCheckBox275.Checked);
            sw.WriteLine(bunifuCheckBox270.Checked);
            sw.WriteLine(bunifuCheckBox271.Checked);
            sw.WriteLine(bunifuCheckBox276.Checked);
            sw.WriteLine(bunifuCheckBox277.Checked);
            sw.WriteLine(bunifuCheckBox278.Checked);
            sw.WriteLine(bunifuCheckBox279.Checked);
            sw.WriteLine(bunifuCheckBox280.Checked);
            sw.WriteLine(bunifuCheckBox281.Checked);
            sw.WriteLine(bunifuCheckBox282.Checked);
            sw.WriteLine(bunifuCheckBox471.Checked);
            sw.WriteLine(bunifuCheckBox272.Checked);
            sw.WriteLine(bunifuCheckBox273.Checked);
            sw.WriteLine(bunifuCheckBox286.Checked);
            sw.WriteLine(bunifuCheckBox285.Checked);
            sw.WriteLine(bunifuCheckBox284.Checked);
            sw.WriteLine(bunifuCheckBox283.Checked);
            sw.WriteLine(bunifuCheckBox290.Checked);
            sw.WriteLine(bunifuCheckBox289.Checked);
            sw.WriteLine(bunifuCheckBox288.Checked);
            sw.WriteLine(bunifuCheckBox291.Checked);
            sw.WriteLine(bunifuCheckBox287.Checked);
            sw.WriteLine(bunifuMaterialTextbox36.Text);
            sw.WriteLine(bunifuCheckBox293.Checked);
            sw.WriteLine(bunifuCheckBox292.Checked);
            sw.WriteLine(bunifuMaterialTextbox37.Text);
            sw.WriteLine(bunifuCheckBox300.Checked);
            sw.WriteLine(bunifuCheckBox299.Checked);
            sw.WriteLine(bunifuCheckBox298.Checked);
            sw.WriteLine(bunifuCheckBox297.Checked);
            sw.WriteLine(bunifuCheckBox296.Checked);
            sw.WriteLine(bunifuCheckBox295.Checked);
            sw.WriteLine(bunifuCheckBox294.Checked);
            sw.WriteLine(bunifuCheckBox307.Checked);
            sw.WriteLine(bunifuCheckBox306.Checked);
            sw.WriteLine(bunifuCheckBox305.Checked);
            sw.WriteLine(bunifuCheckBox304.Checked);
            sw.WriteLine(bunifuCheckBox303.Checked);
            sw.WriteLine(bunifuCheckBox302.Checked);
            sw.WriteLine(bunifuCheckBox323.Checked);
            sw.WriteLine(bunifuCheckBox322.Checked);
            sw.WriteLine(bunifuMaterialTextbox39.Text);
            sw.WriteLine(bunifuCheckBox321.Checked);
            sw.WriteLine(bunifuCheckBox320.Checked);
            sw.WriteLine(bunifuCheckBox324.Checked);
            sw.WriteLine(bunifuCheckBox313.Checked);
            sw.WriteLine(bunifuCheckBox312.Checked);
            sw.WriteLine(bunifuCheckBox311.Checked);
            sw.WriteLine(bunifuCheckBox310.Checked);
            sw.WriteLine(bunifuCheckBox309.Checked);
            sw.WriteLine(bunifuCheckBox308.Checked);
            sw.WriteLine(bunifuCheckBox301.Checked);
            sw.WriteLine(bunifuCheckBox319.Checked);
            sw.WriteLine(bunifuCheckBox318.Checked);
            sw.WriteLine(bunifuMaterialTextbox62.Text);
            sw.WriteLine(bunifuMaterialTextbox60.Text);
            sw.WriteLine(bunifuMaterialTextbox58.Text);
            sw.WriteLine(bunifuMaterialTextbox56.Text);
            sw.WriteLine(bunifuMaterialTextbox54.Text);
            sw.WriteLine(bunifuMaterialTextbox52.Text);
            sw.WriteLine(bunifuMaterialTextbox44.Text);
            sw.WriteLine(bunifuMaterialTextbox43.Text);
            sw.WriteLine(bunifuMaterialTextbox42.Text);
            sw.WriteLine(bunifuMaterialTextbox38.Text);
            sw.WriteLine(bunifuMaterialTextbox40.Text);
            sw.WriteLine(bunifuCheckBox331.Checked);
            sw.WriteLine(bunifuCheckBox332.Checked);
            sw.WriteLine(bunifuCheckBox330.Checked);
            sw.WriteLine(bunifuCheckBox333.Checked);
            sw.WriteLine(bunifuCheckBox329.Checked);
            sw.WriteLine(bunifuCheckBox328.Checked);
            sw.WriteLine(bunifuCheckBox327.Checked);
            sw.WriteLine(bunifuCheckBox326.Checked);
            sw.WriteLine(bunifuCheckBox325.Checked);
            sw.WriteLine(bunifuCheckBox317.Checked);
            sw.WriteLine(bunifuCheckBox316.Checked);
            sw.WriteLine(bunifuCheckBox315.Checked);
            sw.WriteLine(bunifuCheckBox334.Checked);
            sw.WriteLine(bunifuCheckBox335.Checked);
            sw.WriteLine(bunifuCheckBox314.Checked);
            sw.WriteLine(bunifuCheckBox336.Checked);
            sw.WriteLine(bunifuCheckBox337.Checked);
            sw.WriteLine(bunifuCheckBox338.Checked);
            sw.WriteLine(bunifuCheckBox339.Checked);
            sw.WriteLine(bunifuCheckBox340.Checked);
            sw.WriteLine(bunifuCheckBox341.Checked);
            sw.WriteLine(bunifuCheckBox342.Checked);
            sw.WriteLine(bunifuCheckBox343.Checked);
            sw.WriteLine(bunifuCheckBox344.Checked);
            sw.WriteLine(bunifuCheckBox345.Checked);
            sw.WriteLine(bunifuCheckBox346.Checked);
            sw.WriteLine(bunifuMaterialTextbox47.Text);
            sw.WriteLine(bunifuMaterialTextbox48.Text);
            sw.WriteLine(bunifuMaterialTextbox49.Text);
            sw.WriteLine(bunifuMaterialTextbox50.Text);
            sw.WriteLine(bunifuMaterialTextbox51.Text);
            sw.WriteLine(bunifuMaterialTextbox53.Text);
            sw.WriteLine(bunifuMaterialTextbox41.Text);
            sw.WriteLine(bunifuMaterialTextbox45.Text);
            sw.WriteLine(bunifuMaterialTextbox46.Text);
            sw.WriteLine(bunifuMaterialTextbox55.Text);
            sw.WriteLine(bunifuMaterialTextbox57.Text);





            sw.Close();
            MessageBox.Show("Successfully Saved");
        }
        private void Form_Pengkajian_Load(object sender, EventArgs e)
        {
            if (stats == "Load")
            {
                //TABPAGE 1
                line = File.ReadAllLines(strfilename);
                bunifuTextBox10.Text = line[0];
                TB_NoMEDREC.Text = line[1];
                TB_Jam.Text = line[2];
                TB_DPJP.Text = line[3];
                TB_NamaPasien.Text = line[4];
                bunifuTextBox9.Text = line[5];
                TB_UsiaPasien.Text = line[6];
                CB_AgamaPasien.selectedIndex = Convert.ToInt32(line[7]);
                CB_PendidikanPasien.selectedIndex = Convert.ToInt32(line[8]);
                CB_PekerjaanPasien.selectedIndex = Convert.ToInt32(line[9]);
                CB_StatusPerkawinanPasien.selectedIndex = Convert.ToInt32(line[10]);
                TB_AlamatPasien.Text = line[11];
                TB_NamaKeluarga.Text = line[12];
                bunifuTextBox8.Text = line[13];
                TB_UsiaKeluarga.Text = line[14];
                CB_AgamaKeluarga.selectedIndex = Convert.ToInt32(line[15]);
                CB_PendidikanKeluarga.selectedIndex = Convert.ToInt32(line[16]);
                CB_PekerjaanKeluarga.selectedIndex = Convert.ToInt32(line[17]);
                CB_StatusPerkawinanKeluarga.selectedIndex = Convert.ToInt32(line[18]);
                TB_AlamatKeluarga.Text = line[19];
                bunifuTextBox1.Text = line[20];
                bunifuTextBox2.Text = line[21];
                bunifuTextBox3.Text = line[22];
                bunifuTextBox4.Text = line[23];
                CB_Ambulasi.SelectedIndex = Convert.ToInt32(line[24]);
                CB_StatusFungsional.SelectedIndex = Convert.ToInt32(line[25]);
                CB_KemampauanMerawatDiri.SelectedIndex = Convert.ToInt32(line[26]);
                CB_Intake.SelectedIndex = Convert.ToInt32(line[27]);
                CB_TingkatKesadaran.SelectedIndex = Convert.ToInt32(line[28]);

                //TABPAGE 2
                TB_Sistol.Text = line[29];
                TB_Diastole.Text = line[30];
                TB_MAP.Text = line[31];
                TB_Nadi.Text = line[32];
                TB_InterpretasiNadi.Text = line[33];
                CB_NadiTerabaLemah.Checked = bool.Parse(line[34]);
                CB_NadiTerabaKuat.Checked = bool.Parse(line[35]);
                bunifuCheckBox473.Checked = bool.Parse(line[36]);
                bunifuCheckBox472.Checked = bool.Parse(line[37]);
                TB_FrekuensiPernapasan.Text = line[38];
                TB_InterpretasiFrekuensiPernapasan.Text = line[39];
                TB_Suhu.Text = line[40];
                TB_InterpretasiSuhu.Text = line[41];
                CB_SkalaNyeri.selectedIndex = Convert.ToInt32(line[42]);
                TB_InterpretasiSkalaNyeri.Text = line[43];
                TB_FrekuensiNyeri.Text = line[44];
                TB_DurasiNyeri.Text = line[45];
                TB_InterpretasiSuhu.Text = line[46];
                TB_LokasiNyeri.Text = line[47];
                CB_LamaMerasaNyeri.selectedIndex = Convert.ToInt32(line[48]);
                bunifuDropdown1.selectedIndex = Convert.ToInt32(line[49]);
                bunifuCheckBox9.Checked = bool.Parse(line[50]);
                bunifuCheckBox6.Checked = bool.Parse(line[51]);
                bunifuCheckBox2.Checked = bool.Parse(line[52]);
                bunifuCheckBox1.Checked = bool.Parse(line[53]);
                bunifuCheckBox11.Checked = bool.Parse(line[54]);
                bunifuCheckBox10.Checked = bool.Parse(line[55]);
                bunifuCheckBox4.Checked = bool.Parse(line[56]);
                bunifuCheckBox3.Checked = bool.Parse(line[57]);
                bunifuCheckBox13.Checked = bool.Parse(line[58]);
                bunifuCheckBox12.Checked = bool.Parse(line[59]);
                bunifuCheckBox5.Checked = bool.Parse(line[60]);
                bunifuCheckBox7.Checked = bool.Parse(line[61]);
                bunifuCheckBox8.Checked = bool.Parse(line[62]);
                bunifuCheckBox14.Checked = bool.Parse(line[63]);
                bunifuCheckBox16.Checked = bool.Parse(line[64]);
                bunifuCheckBox17.Checked = bool.Parse(line[65]);
                bunifuCheckBox28.Checked = bool.Parse(line[66]);
                bunifuCheckBox29.Checked = bool.Parse(line[67]);
                bunifuCheckBox19.Checked = bool.Parse(line[68]);
                bunifuCheckBox20.Checked = bool.Parse(line[69]);
                bunifuCheckBox30.Checked = bool.Parse(line[70]);
                bunifuCheckBox18.Checked = bool.Parse(line[71]);
                bunifuCheckBox31.Checked = bool.Parse(line[72]);
                bunifuCheckBox22.Checked = bool.Parse(line[73]);
                bunifuCheckBox23.Checked = bool.Parse(line[74]);
                bunifuCheckBox32.Checked = bool.Parse(line[75]);
                bunifuCheckBox33.Checked = bool.Parse(line[76]);
                bunifuCheckBox21.Checked = bool.Parse(line[77]);
                bunifuCheckBox24.Checked = bool.Parse(line[78]);
                bunifuCheckBox25.Checked = bool.Parse(line[79]);
                bunifuCheckBox36.Checked = bool.Parse(line[80]);
                bunifuCheckBox37.Checked = bool.Parse(line[81]);
                bunifuCheckBox34.Checked = bool.Parse(line[82]);
                bunifuCheckBox38.Checked = bool.Parse(line[83]);
                bunifuCheckBox26.Checked = bool.Parse(line[84]);
                bunifuCheckBox27.Checked = bool.Parse(line[85]);
                bunifuCheckBox39.Checked = bool.Parse(line[86]);
                bunifuCheckBox40.Checked = bool.Parse(line[87]);
                bunifuCheckBox41.Checked = bool.Parse(line[88]);
                bunifuCheckBox42.Checked = bool.Parse(line[89]);
                bunifuCheckBox43.Checked = bool.Parse(line[90]);
                bunifuCheckBox44.Checked = bool.Parse(line[91]);
                bunifuCheckBox45.Checked = bool.Parse(line[92]);
                bunifuCheckBox46.Checked = bool.Parse(line[93]);
                bunifuCheckBox47.Checked = bool.Parse(line[94]);
                bunifuCheckBox48.Checked = bool.Parse(line[95]);
                bunifuCheckBox49.Checked = bool.Parse(line[96]);
                bunifuCheckBox50.Checked = bool.Parse(line[97]);
                bunifuCheckBox51.Checked = bool.Parse(line[98]);
                bunifuCheckBox52.Checked = bool.Parse(line[99]);
                bunifuCheckBox53.Checked = bool.Parse(line[100]);
                bunifuCheckBox54.Checked = bool.Parse(line[101]);
                bunifuCheckBox55.Checked = bool.Parse(line[102]);
                bunifuCheckBox56.Checked = bool.Parse(line[103]);
                bunifuCheckBox57.Checked = bool.Parse(line[104]);
                bunifuCheckBox58.Checked = bool.Parse(line[105]);
                bunifuMaterialTextbox1.Text = line[106];
                bunifuCheckBox59.Checked = bool.Parse(line[107]);
                bunifuCheckBox60.Checked = bool.Parse(line[108]);
                bunifuCheckBox61.Checked = bool.Parse(line[109]);
                bunifuCheckBox62.Checked = bool.Parse(line[110]);
                bunifuCheckBox63.Checked = bool.Parse(line[111]);
                bunifuCheckBox64.Checked = bool.Parse(line[112]);
                bunifuCheckBox65.Checked = bool.Parse(line[113]);
                bunifuCheckBox66.Checked = bool.Parse(line[114]);
                bunifuCheckBox67.Checked = bool.Parse(line[115]);
                bunifuCheckBox68.Checked = bool.Parse(line[116]);
                bunifuCheckBox69.Checked = bool.Parse(line[117]);
                bunifuCheckBox70.Checked = bool.Parse(line[118]);
                bunifuCheckBox71.Checked = bool.Parse(line[119]);
                bunifuCheckBox75.Checked = bool.Parse(line[120]);
                bunifuCheckBox74.Checked = bool.Parse(line[121]);
                bunifuCheckBox76.Checked = bool.Parse(line[122]);
                bunifuCheckBox78.Checked = bool.Parse(line[123]);
                bunifuCheckBox77.Checked = bool.Parse(line[124]);
                bunifuCheckBox73.Checked = bool.Parse(line[125]);
                bunifuCheckBox81.Checked = bool.Parse(line[126]);
                bunifuCheckBox82.Checked = bool.Parse(line[127]);
                bunifuCheckBox83.Checked = bool.Parse(line[128]);
                bunifuCheckBox72.Checked = bool.Parse(line[129]);
                bunifuMaterialTextbox2.Text = line[130];
                bunifuCheckBox79.Checked = bool.Parse(line[131]);
                bunifuCheckBox80.Checked = bool.Parse(line[132]);
                bunifuMaterialTextbox3.Text = line[133];
                bunifuTextBox5.Text = line[134];
                bunifuCheckBox87.Checked = bool.Parse(line[135]);
                bunifuCheckBox86.Checked = bool.Parse(line[136]);
                bunifuCheckBox88.Checked = bool.Parse(line[137]);
                bunifuCheckBox90.Checked = bool.Parse(line[138]);
                bunifuCheckBox89.Checked = bool.Parse(line[139]);
                bunifuCheckBox85.Checked = bool.Parse(line[140]);
                bunifuCheckBox84.Checked = bool.Parse(line[141]);
                bunifuCheckBox91.Checked = bool.Parse(line[142]);
                bunifuCheckBox93.Checked = bool.Parse(line[143]);
                bunifuCheckBox94.Checked = bool.Parse(line[144]);
                bunifuCheckBox92.Checked = bool.Parse(line[145]);
                bunifuCheckBox95.Checked = bool.Parse(line[146]);
                bunifuCheckBox97.Checked = bool.Parse(line[147]);
                bunifuCheckBox101.Checked = bool.Parse(line[148]);
                bunifuCheckBox100.Checked = bool.Parse(line[149]);
                bunifuCheckBox102.Checked = bool.Parse(line[150]);
                bunifuCheckBox104.Checked = bool.Parse(line[151]);
                bunifuCheckBox103.Checked = bool.Parse(line[152]);
                bunifuCheckBox99.Checked = bool.Parse(line[153]);
                bunifuCheckBox98.Checked = bool.Parse(line[154]);
                bunifuCheckBox105.Checked = bool.Parse(line[155]);
                bunifuCheckBox106.Checked = bool.Parse(line[156]);
                bunifuCheckBox107.Checked = bool.Parse(line[157]);
                bunifuCheckBox108.Checked = bool.Parse(line[158]);
                bunifuCheckBox109.Checked = bool.Parse(line[159]);
                bunifuCheckBox96.Checked = bool.Parse(line[160]);
                bunifuCheckBox110.Checked = bool.Parse(line[161]);
                bunifuCheckBox111.Checked = bool.Parse(line[162]);
                bunifuCheckBox112.Checked = bool.Parse(line[163]);
                bunifuCheckBox113.Checked = bool.Parse(line[164]);
                bunifuCheckBox114.Checked = bool.Parse(line[165]);
                bunifuCheckBox115.Checked = bool.Parse(line[166]);
                bunifuCheckBox116.Checked = bool.Parse(line[167]);
                bunifuCheckBox117.Checked = bool.Parse(line[168]);
                bunifuCheckBox439.Checked = bool.Parse(line[169]);
                bunifuCheckBox440.Checked = bool.Parse(line[170]);
                bunifuCheckBox118.Checked = bool.Parse(line[171]);
                bunifuCheckBox119.Checked = bool.Parse(line[172]);
                bunifuCheckBox120.Checked = bool.Parse(line[173]);
                bunifuCheckBox124.Checked = bool.Parse(line[174]);
                bunifuCheckBox122.Checked = bool.Parse(line[175]);
                bunifuCheckBox125.Checked = bool.Parse(line[176]);
                bunifuCheckBox121.Checked = bool.Parse(line[177]);
                bunifuCheckBox126.Checked = bool.Parse(line[178]);
                bunifuCheckBox127.Checked = bool.Parse(line[179]);
                bunifuCheckBox123.Checked = bool.Parse(line[180]);
                bunifuCheckBox128.Checked = bool.Parse(line[181]);
                bunifuCheckBox129.Checked = bool.Parse(line[182]);
                bunifuCheckBox130.Checked = bool.Parse(line[183]);
                bunifuCheckBox131.Checked = bool.Parse(line[184]);
                bunifuCheckBox132.Checked = bool.Parse(line[185]);
                bunifuCheckBox133.Checked = bool.Parse(line[186]);
                bunifuCheckBox134.Checked = bool.Parse(line[187]);
                bunifuCheckBox135.Checked = bool.Parse(line[188]);
                bunifuCheckBox136.Checked = bool.Parse(line[189]);
                bunifuCheckBox137.Checked = bool.Parse(line[190]);
                bunifuCheckBox138.Checked = bool.Parse(line[191]);
                bunifuCheckBox140.Checked = bool.Parse(line[192]);
                bunifuCheckBox141.Checked = bool.Parse(line[193]);
                bunifuCheckBox436.Checked = bool.Parse(line[194]);
                bunifuCheckBox433.Checked = bool.Parse(line[195]);
                bunifuCheckBox437.Checked = bool.Parse(line[196]);
                bunifuCheckBox438.Checked = bool.Parse(line[197]);
                bunifuMaterialTextbox5.Text = line[198];
                bunifuCheckBox139.Checked = bool.Parse(line[199]);
                bunifuCheckBox142.Checked = bool.Parse(line[200]);
                bunifuCheckBox143.Checked = bool.Parse(line[201]);
                bunifuCheckBox144.Checked = bool.Parse(line[202]);
                bunifuCheckBox167.Checked = bool.Parse(line[203]);
                bunifuCheckBox168.Checked = bool.Parse(line[204]);
                bunifuCheckBox165.Checked = bool.Parse(line[205]);
                bunifuCheckBox166.Checked = bool.Parse(line[206]);
                bunifuCheckBox163.Checked = bool.Parse(line[207]);
                bunifuCheckBox164.Checked = bool.Parse(line[208]);
                bunifuCheckBox157.Checked = bool.Parse(line[209]);
                bunifuCheckBox158.Checked = bool.Parse(line[210]);
                bunifuCheckBox161.Checked = bool.Parse(line[211]);
                bunifuCheckBox162.Checked = bool.Parse(line[212]);
                bunifuCheckBox159.Checked = bool.Parse(line[213]);
                bunifuCheckBox160.Checked = bool.Parse(line[214]);
                bunifuCheckBox155.Checked = bool.Parse(line[215]);
                bunifuCheckBox156.Checked = bool.Parse(line[216]);
                bunifuTextBox6.Text = line[217];
                bunifuCheckBox15.Checked = bool.Parse(line[218]);

                
                
                
                
                
                //TABPAGE 3
                bunifuCheckBox145.Checked = bool.Parse(line[219]);
                bunifuCheckBox146.Checked = bool.Parse(line[220]);
                bunifuCheckBox147.Checked = bool.Parse(line[221]);
                bunifuCheckBox154.Checked = bool.Parse(line[222]);
                bunifuCheckBox169.Checked = bool.Parse(line[223]);
                bunifuCheckBox152.Checked = bool.Parse(line[224]);
                bunifuCheckBox153.Checked = bool.Parse(line[225]);
                bunifuCheckBox170.Checked = bool.Parse(line[226]);
                bunifuCheckBox171.Checked = bool.Parse(line[227]);
                bunifuCheckBox172.Checked = bool.Parse(line[228]);
                bunifuCheckBox173.Checked = bool.Parse(line[229]);
                bunifuCheckBox174.Checked = bool.Parse(line[230]);
                bunifuCheckBox175.Checked = bool.Parse(line[231]);
                bunifuCheckBox176.Checked = bool.Parse(line[232]);
                bunifuCheckBox177.Checked = bool.Parse(line[233]);
                bunifuCheckBox178.Checked = bool.Parse(line[234]);
                bunifuCheckBox179.Checked = bool.Parse(line[235]);
                bunifuCheckBox180.Checked = bool.Parse(line[236]);
                bunifuCheckBox181.Checked = bool.Parse(line[237]);
                bunifuCheckBox190.Checked = bool.Parse(line[238]);
                bunifuCheckBox191.Checked = bool.Parse(line[239]);
                bunifuCheckBox192.Checked = bool.Parse(line[240]);
                bunifuCheckBox207.Checked = bool.Parse(line[241]);
                bunifuCheckBox206.Checked = bool.Parse(line[242]);
                bunifuCheckBox205.Checked = bool.Parse(line[243]);
                bunifuCheckBox204.Checked = bool.Parse(line[244]);
                bunifuCheckBox203.Checked = bool.Parse(line[245]);
                bunifuCheckBox202.Checked = bool.Parse(line[246]);
                bunifuCheckBox201.Checked = bool.Parse(line[247]);
                bunifuCheckBox187.Checked = bool.Parse(line[248]);
                bunifuCheckBox188.Checked = bool.Parse(line[249]);
                bunifuCheckBox185.Checked = bool.Parse(line[250]);
                bunifuCheckBox189.Checked = bool.Parse(line[251]);
                bunifuCheckBox183.Checked = bool.Parse(line[252]);
                bunifuCheckBox184.Checked = bool.Parse(line[253]);
                bunifuCheckBox186.Checked = bool.Parse(line[254]);
                bunifuMaterialTextbox7.Text = line[255];
                bunifuMaterialTextbox4.Text = line[256];
                bunifuTextBox7.Text = line[257];
                bunifuMaterialTextbox8.Text = line[258];
                bunifuMaterialTextbox6.Text = line[259];
                bunifuMaterialTextbox9.Text = line[260];
                bunifuCheckBox194.Checked = bool.Parse(line[261]);
                bunifuCheckBox195.Checked = bool.Parse(line[262]);
                bunifuCheckBox193.Checked = bool.Parse(line[263]);
                bunifuMaterialTextbox10.Text = line[264];
                bunifuCheckBox197.Checked = bool.Parse(line[265]);
                bunifuCheckBox198.Checked = bool.Parse(line[266]);
                bunifuCheckBox196.Checked = bool.Parse(line[267]);
                bunifuMaterialTextbox35.Text = line[268];
                bunifuCheckBox218.Checked = bool.Parse(line[269]);
                bunifuCheckBox217.Checked = bool.Parse(line[270]);
                bunifuCheckBox216.Checked = bool.Parse(line[271]);
                bunifuCheckBox215.Checked = bool.Parse(line[272]);
                bunifuCheckBox214.Checked = bool.Parse(line[273]);
                bunifuCheckBox213.Checked = bool.Parse(line[274]);
                bunifuCheckBox212.Checked = bool.Parse(line[275]);
                bunifuCheckBox228.Checked = bool.Parse(line[276]);
                bunifuCheckBox227.Checked = bool.Parse(line[277]);
                bunifuCheckBox211.Checked = bool.Parse(line[278]);
                bunifuCheckBox210.Checked = bool.Parse(line[279]);
                bunifuCheckBox209.Checked = bool.Parse(line[280]);
                bunifuCheckBox208.Checked = bool.Parse(line[281]);
                bunifuCheckBox200.Checked = bool.Parse(line[282]);
                bunifuCheckBox199.Checked = bool.Parse(line[283]);
                bunifuCheckBox182.Checked = bool.Parse(line[284]);
                bunifuCheckBox235.Checked = bool.Parse(line[285]);
                bunifuCheckBox234.Checked = bool.Parse(line[286]);
                bunifuCheckBox229.Checked = bool.Parse(line[287]);
                bunifuCheckBox224.Checked = bool.Parse(line[288]);
                bunifuCheckBox223.Checked = bool.Parse(line[289]);
                bunifuCheckBox222.Checked = bool.Parse(line[290]);
                bunifuCheckBox221.Checked = bool.Parse(line[291]);
                bunifuCheckBox220.Checked = bool.Parse(line[292]);
                bunifuCheckBox219.Checked = bool.Parse(line[293]);
                bunifuCheckBox225.Checked = bool.Parse(line[294]);
                bunifuCheckBox474.Checked = bool.Parse(line[295]);
                bunifuCheckBox475.Checked = bool.Parse(line[296]);
                bunifuCheckBox233.Checked = bool.Parse(line[297]);
                bunifuCheckBox232.Checked = bool.Parse(line[298]);
                bunifuCheckBox236.Checked = bool.Parse(line[299]);
                bunifuCheckBox230.Checked = bool.Parse(line[300]);
                bunifuCheckBox231.Checked = bool.Parse(line[301]);
                bunifuCheckBox226.Checked = bool.Parse(line[302]);
                bunifuCheckBox237.Checked = bool.Parse(line[303]);
                bunifuCheckBox238.Checked = bool.Parse(line[304]);
                bunifuCheckBox239.Checked = bool.Parse(line[305]);
                bunifuCheckBox240.Checked = bool.Parse(line[306]);
                bunifuCheckBox241.Checked = bool.Parse(line[307]);
                bunifuCheckBox242.Checked = bool.Parse(line[308]);
            }
        }


    }
}
