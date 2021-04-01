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

namespace Zaliczenie_2
{
    public partial class Form1 : Form
    {
        private double suma;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void WyswietlenieSumy_Click(object sender, EventArgs e)
        {
           
        }

        private void SZNYCEL_WIEPRZOWY_CheckedChanged(object sender, EventArgs e)
        {
            if (SZNYCEL_WIEPRZOWY.Checked==true)
            {
                suma += 29;
            }
            if (SZNYCEL_WIEPRZOWY.Checked == false)
            {
                suma -= 29;
            }
        }

        private void Ryz_kurczak_CheckedChanged(object sender, EventArgs e)
        {
            if (ryz_kurczak.Checked == true)
            {
                suma += 29;
            }
            if (ryz_kurczak.Checked == false)
            {
                suma -= 29;
            }
        }

        private void Pierogi_CheckedChanged(object sender, EventArgs e)
        {
            if (pierogi.Checked==true == true)
            {
                suma += 14;
            }
            if (pierogi.Checked == false)
            {
                suma -= 14;
            }
        }

        private void SPAGHETTI_BOLOGNESE_CheckedChanged(object sender, EventArgs e)
        {
            if (SPAGHETTI_BOLOGNESE.Checked==true)
            {
                suma += 21;
            }
            if (SPAGHETTI_BOLOGNESE.Checked==false)
            {
                suma -= 21;
            }
        }

        private void SPAGHETTI_CARBONARA_CheckedChanged(object sender, EventArgs e)
        {
            if (SPAGHETTI_CARBONARA.Checked == true)
            {
                suma += 24;
            }
            if (SPAGHETTI_CARBONARA.Checked == false)
            {
                suma -= 24;
            }
        }

        private void MARGHERITA_CheckedChanged(object sender, EventArgs e)
        {
            if (MARGHERITA.Checked == true)
            {
                suma += 29;
            }
            if (MARGHERITA.Checked == false)
            {
                suma -= 29;
            }
        }

        private void FUNGHI_CheckedChanged(object sender, EventArgs e)
        {
            if (FUNGHI.Checked == true)
            {
                suma += 31;
            }
            if (FUNGHI.Checked == false)
            {
                suma -= 31;
            }
        }

        private void HAVAI_CheckedChanged(object sender, EventArgs e)
        {
            if (HAVAI.Checked == true)
            {
                suma += 37;
            }
            if (HAVAI.Checked == false)
            {
                suma -= 37;
            }
        }

        private void ALL_PROSCIUTTO_CheckedChanged(object sender, EventArgs e)
        {
            if (ALL_PROSCIUTTO.Checked == true)
            {
                suma += 36;
            }
            if (ALL_PROSCIUTTO.Checked == false)
            {
                suma -= 36;
            }
        }

        private void NAPOLITANA_CheckedChanged(object sender, EventArgs e)
        {
            if (NAPOLITANA.Checked == true)
            {
                suma += 37;
            }
            if (NAPOLITANA.Checked == false)
            {
                suma -= 37;
            }
        }

        private void CARPACCIO_CheckedChanged(object sender, EventArgs e)
        {
            if (CARPACCIO.Checked == true)
            {
                suma += 30;
            }
            if (CARPACCIO.Checked == false)
            {
                suma -= 30;
            }
        }

        private void POLĘDWICZKI_WIEPRZOWE_CheckedChanged(object sender, EventArgs e)
        {
            if (POLĘDWICZKI_WIEPRZOWE.Checked == true)
            {
                suma += 34;
            }
            if (POLĘDWICZKI_WIEPRZOWE.Checked ==false)
            {
                suma -= 34;
            }
        }

        private void PARÓWECZKI_CheckedChanged(object sender, EventArgs e)
        {
            if (PARÓWECZKI.Checked == true)
            {
                suma += 18;
            }
            if (PARÓWECZKI.Checked == false)
            {
                suma -= 18;
            }
        }

        private void GRZANKI_CheckedChanged(object sender, EventArgs e)
        {
            if (GRZANKI.Checked == true)
            {
                suma += 8;
            }
            if (GRZANKI.Checked == false)
            {
                suma -= 8;
            }
        }

        private void COLA_CheckedChanged(object sender, EventArgs e)
        {
            if (COLA.Checked == true)
            {
                suma += 3;
            }
            if (COLA.Checked == false)
            {
                suma -= 3;
            }

        }

        private void NESTEA_CheckedChanged(object sender, EventArgs e)
        {
            if (NESTEA.Checked == true)
            {
                suma += 6;
            }
            if (NESTEA.Checked == false)
            {
                suma -= 6;
            }
        }

        private void WODA_CheckedChanged(object sender, EventArgs e)
        {
            if (WODA.Checked == true)
            {
                suma += 3;
            }
            if (WODA.Checked == false)
            {
                suma -= 3;
            }
        }

        private void SOKI_CheckedChanged(object sender, EventArgs e)
        {
            if (SOKI.Checked == true)
            {
                suma += 4;
            }
            if (SOKI.Checked == false)
            {
                suma -= 4;
            }
        }

        private void SumaZamowienia_Click(object sender, EventArgs e)
        {
            wyswietlenieSumy.Text = suma.ToString();
        }

        private void Kasa_Click(object sender, EventArgs e)
        {
            
            string sciezkaPliku= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter outputFile = new StreamWriter(Path.Combine(sciezkaPliku, "paragon.txt"));
            outputFile.Write("IMIE: ");
            outputFile.WriteLine(Imie.Text);
            outputFile.Write("NAZWISKO: ");
            outputFile.WriteLine(Nazwisko.Text);
            if (SZNYCEL_WIEPRZOWY.Checked == true)
            {
                outputFile.WriteLine(SZNYCEL_WIEPRZOWY.Text);
            }
            if (ryz_kurczak.Checked == true)
            {
                outputFile.WriteLine(ryz_kurczak.Text);
            }
            if (pierogi.Checked == true)
            {
                outputFile.WriteLine(pierogi.Text);
            }
            if (SPAGHETTI_BOLOGNESE.Checked == true)
            {
                outputFile.WriteLine(SPAGHETTI_BOLOGNESE.Text);
            }
            if (SPAGHETTI_CARBONARA.Checked == true)
            {
                outputFile.WriteLine(SPAGHETTI_CARBONARA.Text);
            }
            if (MARGHERITA.Checked == true)
            {
                outputFile.WriteLine(MARGHERITA.Text);
            }
            if (FUNGHI.Checked == true)
            {
                outputFile.WriteLine(FUNGHI.Text);
            }
            if (HAVAI.Checked == true)
            {
                outputFile.WriteLine(HAVAI.Text);
            }
            if (ALL_PROSCIUTTO.Checked == true)
            {
                outputFile.WriteLine(ALL_PROSCIUTTO.Text);
            }
            if (NAPOLITANA.Checked == true)
            {
                outputFile.WriteLine(NAPOLITANA.Text);
            }
            if (CARPACCIO.Checked == true)
            {
                outputFile.WriteLine(CARPACCIO.Text);
            }
            if (POLĘDWICZKI_WIEPRZOWE.Checked == true)
            {
                outputFile.WriteLine(POLĘDWICZKI_WIEPRZOWE.Text);
            }
            if (PARÓWECZKI.Checked == true)
            {
                outputFile.WriteLine(PARÓWECZKI.Text);
            }
            if (GRZANKI.Checked == true)
            {
                outputFile.WriteLine(GRZANKI.Text);
            }
            if (COLA.Checked == true)
            {
                outputFile.WriteLine(COLA.Text);
            }
            if (NESTEA.Checked == true)
            {
                outputFile.WriteLine(NESTEA.Text);
            }
            if (WODA.Checked == true)
            {
                outputFile.WriteLine(WODA.Text);
            }
            if (SOKI.Checked == true)
            {
                outputFile.WriteLine(SOKI.Text);
            }
            outputFile.Write("RAZEM: ");
            outputFile.WriteLine(suma);
            outputFile.Close();
            this.Close();
        }

        private void NazwiskoLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
