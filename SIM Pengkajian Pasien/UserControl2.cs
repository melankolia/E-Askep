using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SIM_Pengkajian_Pasien
{
    public partial class UserControl2 : UserControl
    {
        static string regexPattern = "^[0-9]{1,}$";
        Regex regex = new Regex(regexPattern);
        public UserControl2()
        {
            InitializeComponent();
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
    }
}
