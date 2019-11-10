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
