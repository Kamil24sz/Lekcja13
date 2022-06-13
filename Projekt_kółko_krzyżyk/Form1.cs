using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_kółko_krzyżyk
{
    public partial class Form1 : Form
    {
        //zmienna zadeklarowana w tym obszarze będzie dostępna dla wszystkich funkcji
        private bool czyj_ruch = true; //true to X, false to O
        public Form1()
        {
            InitializeComponent();
        }

        //1.Funkcja sprawdzająca czy ktoś wygrał. (ta funkcja zwraca true lub false)
        private bool SprawdzCzyKtosWygral()
        {
            // Sprawdzamy pierwszy wiersz
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
                return true;

            // Sprawdzamy drugi wiersz
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
                return true;

            // Sprawdzamy trzeci wiersz
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
                return true;

            // Sprawdzamy pierwszą kolumnę
            else if(btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
                return true;

            // Sprawdzamy drugą kolumnę
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
                return true;

            // Sprawdzamy trzecią kolumnę
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
                return true;

            //Sprawdzamy skos nr1 
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
                return true;

            //Sprawdzamy skos nr2
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
                return true;

            return false;
        }

        //1 2 3
        //4 5 6
        //7 8 9
        //2.Funkcja restartująca planszę. (ta funkcja może być typu void)
        private void Resetuj()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        //3.Funkcja, która wstawi znak do przycisku.
        private void WstawZnak(object przycisk)
        {
            //rzutowanie przekazanaego argumentu na typ przycisku
            Button wcisnietyPrzycisk = (Button)przycisk;

            if (czyj_ruch ==true)
            {
                wcisnietyPrzycisk.Text = "X";
            }
            else
            {
                wcisnietyPrzycisk.Text = "O";
            }
            //wyłączenie przycisku aby nikt go nie kliknął
            wcisnietyPrzycisk.Enabled = false;

            //sprawdzenie czy ktoś wygrał
            bool wynik = SprawdzCzyKtosWygral();

            if(wynik == true)
            {
                string tekstWygranej;
                if(czyj_ruch == true)
                {
                    tekstWygranej = "Wygrał gracz X! Rozpocząć jeszcze raz?";
                }
                else
                {
                    tekstWygranej = "Wygrał gracz O! Rozpocząć jeszcze raz?";
                }

                //Poinformowanie gracza o rezultacie + pytanie o kontuacje gry
                DialogResult odpowiedz = MessageBox.Show(tekstWygranej, "Wygrana", MessageBoxButtons.YesNo);

                if(odpowiedz == DialogResult.No)
                {
                    WylaczWszystkiePrzyciski();
                }
                else
                {
                    Resetuj();
                }
                czyj_ruch = !czyj_ruch;
                if (czyj_ruch == true)
                {
                    lblCzyjRuch.Text = "X";
                }
                else
                {
                    lblCzyjRuch.Text = "O";
                }
            }

        }

        //4.Funkcja kończąca, która wyłaćza wszystkie przyciski
        private void WylaczWszystkiePrzyciski()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            WstawZnak(sender);
        }
    }
}
