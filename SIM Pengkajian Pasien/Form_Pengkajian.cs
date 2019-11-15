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
                hasil = Convert.ToDouble(bunifuMaterialTextbox9.Text) * 20;
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
            bunifuPages1.PageIndex = 4;
        }

        private void B_Psikologis_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
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
                    TB_InterpretasiNadi.Text = "Bradikardi";
                }
                else if (nadi > 60 && nadi <= 100)
                {
                    TB_InterpretasiNadi.Text = "Normal";
                }
                else if (nadi > 100)
                {
                    TB_InterpretasiNadi.Text = "Takikardi";
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
                    TB_InterpretasiSuhu.Text = "Hipotermi";
                }
                else if (Suhu > 37.5)
                {
                    TB_InterpretasiSuhu.Text = "Hipertermi";
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
            }
            else
            {
                bunifuMaterialTextbox47.Enabled = false;
            }
        }

        private void BunifuCheckBox337_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox337.Checked == true)
            {
                bunifuMaterialTextbox48.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox48.Enabled = false;
            }
        }

        private void BunifuCheckBox338_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox338.Checked == true)
            {
                bunifuMaterialTextbox49.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox49.Enabled = false;
            }
        }
        private void BunifuCheckBox339_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox339.Checked == true)
            {
                bunifuMaterialTextbox50.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox50.Enabled = false;
            }
        }
        private void BunifuCheckBox340_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox340.Checked == true)
            {
                bunifuMaterialTextbox51.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox51.Enabled = false;
            }
        }



        private void BunifuCheckBox341_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox341.Checked == true)
            {
                bunifuMaterialTextbox53.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox53.Enabled = false;
            }
        }

        private void BunifuCheckBox342_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox342.Checked == true)
            {
                bunifuMaterialTextbox41.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox41.Enabled = false;
            }
        }
        private void BunifuCheckBox343_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox343.Checked == true)
            {
                bunifuMaterialTextbox45.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox45.Enabled = false;
            }
        }


        private void BunifuCheckBox344_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox344.Checked == true)
            {
                bunifuMaterialTextbox46.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox46.Enabled = false;
            }
        }
        private void BunifuCheckBox345_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox345.Checked == true)
            {
                bunifuMaterialTextbox55.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox55.Enabled = false;
            }
        }
        private void BunifuCheckBox346_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox346.Checked == true)
            {
                bunifuMaterialTextbox57.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox57.Enabled = false;
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
                                                    + convertToNumber(bunifuCheckBox106.Checked) + convertToNumber(bunifuCheckBox117.Checked) + convertToNumber(bunifuCheckBox270.Checked)) / 5.0, 1);
            // Codingan
            MessageBox.Show(BersihanJalanNapasTidakEfektif.ToString());
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
                //buatButton(NamaPenyakit);
            }
            if (DiagnosaCheckbox1.Checked == true)
            {
                string NamaPenyakit = "Konstipasi";
                string[] Penyebab = {   "1. Fisiologis",
                                        "   Penurunan motilitas gastrointestinal",
                                        "   Ketidakadekuatan pertumbuhan gigi",
                                        "   Ketidakcukupan diet",
                                        "   Ketidakcukupan asupan serat",
                                        "   Ketidakcukupan asupan cairan",
                                        "   Aganglionik (mis.penyakit Hircsprung)",
                                        "   Kelemahan otot abdomen" };
                buatLabelDinamis(NamaPenyakit);
                buatDropdown(Penyebab);
                //buatButton(NamaPenyakit);
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
