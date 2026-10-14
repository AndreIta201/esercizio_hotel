using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_hotel
{
    public partial class Form1 : Form
    {
        float prezzo = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string opzioneStanza = cmb_n1.SelectedItem?.ToString();
            string opzioneStagione = cmb_n2.SelectedItem?.ToString();
            // Calcolo del prezzo in base alle opzioni selezionate
            if (opzioneStanza == "Base")
            {
                if (opzioneStagione == "Bassa stagione")
                {
                    prezzo = 15;
                }
                else if (opzioneStagione == "Media stagione")
                {
                    prezzo = 20;
                }
                else if (opzioneStagione == "Alta stagione")
                {
                    prezzo = 25;
                }
            }
            else if(opzioneStanza == "Media")
            {
                if (opzioneStagione == "Bassa stagione")
                {
                    prezzo = 30;
                }
                else if (opzioneStagione == "Media stagione")
                {
                    prezzo = 35;
                }
                else if (opzioneStagione == "Alta stagione")
                {
                    prezzo = 40;
                }
            }
            else if (opzioneStanza == "Alta")
            {
                if (opzioneStagione == "Bassa stagione")
                {
                    prezzo = 45;
                }
                else if (opzioneStagione == "Media stagione")
                {
                    prezzo = 50;
                }
                else if (opzioneStagione == "Alta stagione")
                {
                    prezzo = 55;
                }
            }
            // numero di giorni
            int numeroGiorni = (int)nud_n1.Value;
            prezzo *= numeroGiorni;
            if (nud_n1.Value >= 3 && nud_n1.Value <= 7)
            {
                prezzo *= 0.25f;
            }
            else if (nud_n1.Value > 7)
            {
                prezzo *= 0.35f;
            }
            // check box
            if (chk_n1.Checked)
            {
                prezzo += (5 * numeroGiorni);
            }
            // tariffa parcheggio

            MessageBox.Show($"Il prezzo totale è: {prezzo} €", "Riepilogo Prezzo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
