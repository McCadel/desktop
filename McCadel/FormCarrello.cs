using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCadel
{
    public partial class FormCarrello : Form
    {
        private List<Prodotto> carrello;

        public FormCarrello(List<Prodotto> carrello)
        {
            InitializeComponent();
            this.carrello = carrello;
            FillCarrello();
            lbTotalePrezzo.Text = "Totale: €" + Math.Round(UpdatePrice(), 2);
        }

        public List<Prodotto> Carrello { get => carrello; set => carrello = value; }

        private void FillCarrello()
        {
            tableProdottiCarrello.Controls.Clear();
            tableProdottiCarrello.RowCount = carrello.Count;
            tableProdottiCarrello.RowStyles.Clear();
            if (carrello.Count != 0)
            {
                bprocedi.Visible = true;
                for (int i = 0; i < carrello.Count; i++)
                {
                    tableProdottiCarrello.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    Label nomeProdotto = new Label();
                    nomeProdotto.Text = carrello[i].Nome;

                    Label prezzo = new Label();
                    prezzo.Text = carrello[i].Prezzo + "€";

                    Button eliminaProdotto = new Button();
                    eliminaProdotto.Text = "Rimuovi";
                    eliminaProdotto.Tag = i;
                    eliminaProdotto.Click += elimina;

                    tableProdottiCarrello.Controls.Add(nomeProdotto, 0, i);
                    tableProdottiCarrello.Controls.Add(prezzo, 1, i);
                    tableProdottiCarrello.Controls.Add(eliminaProdotto, 2, i);
                }
            }
            else
            {
                bprocedi.Visible = false;
                tableProdottiCarrello.Visible = false;
                lbCarrelloVuoto.Visible = true;
            }
        }

        private void elimina(object sender, EventArgs e)
        {
            Button bottoneCliccato = (Button)sender;
            carrello.RemoveAt((int)bottoneCliccato.Tag);
            FillCarrello();
            lbTotalePrezzo.Text = "Totale: €" + Math.Round(UpdatePrice(), 2);
        }


        private double UpdatePrice()
        {
            double totale = 0;
            for (int i = 0; i < carrello.Count; i++)
            {
                totale += carrello[i].Prezzo;
            }
            return totale;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableProdottiCarrello_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bprocedi_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormPagamento(carrello).ShowDialog();
            Visible = true;
        }
    }
}
