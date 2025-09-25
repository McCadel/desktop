using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCadel
{
    public partial class UserControlMenu : UserControl
    {
        private Formhall sala;

        public UserControlMenu(Formhall sala)
        {
            this.sala = sala;
            InitializeComponent();

        }

        public void CreateMenu(Sezione s)
        {
            List<Prodotto> listaprodotti=s.Prodotti.ToList();
            int columnCount = 2;
            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(240, 240, 240)
            };

            this.Controls.Clear();
            this.Controls.Add(containerPanel);
            int larghezza = (containerPanel.Width - 30 - (columnCount - 1) * 10) / columnCount;
            int altezza = 120;
            int margin = 8;
            int spacing = 10;

            int riga = 0;
            int colonna = 0;

            foreach (Prodotto p in listaprodotti)
            {
                int xPos = 10 + colonna * (larghezza + spacing);
                int yPos = 10 + riga * (altezza + margin);
                Panel itemPanel = new Panel
                {
                    Location = new Point(xPos, yPos),
                    Size = new Size(larghezza, altezza),
                    Tag = p,
                    BackColor = Color.FromArgb(245, 245, 245),
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand
                };

                Label nome = new Label
                {
                    Text = p.Nome,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    ForeColor = Color.FromArgb(40, 40, 40),
                    Location = new Point(8, 8),
                    Size = new Size(larghezza - 16, 25),
                    TextAlign = ContentAlignment.TopLeft
                };
                Label descrizione = new Label
                {
                    Text = p.Nome,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    ForeColor = Color.FromArgb(100, 100, 100),
                    Location = new Point(8, 35),
                    Size = new Size(larghezza - 16, 50),
                    TextAlign = ContentAlignment.TopLeft
                };

                Label prezzo = new Label
                {
                    Text = $"€ {p.Prezzo:F2}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.FromArgb(255, 196, 37),
                    Location = new Point(8, altezza - 35),
                    Size = new Size(larghezza - 16, 25),
                    TextAlign = ContentAlignment.BottomRight
                };


                descrizione.AutoEllipsis = true;
                itemPanel.Click += (sender, e) => OnMenuItemClick(p);
                nome.Click += (sender, e) => OnMenuItemClick(p);
                descrizione.Click += (sender, e) => OnMenuItemClick(p);
                prezzo.Click += (sender, e) => OnMenuItemClick(p);
                itemPanel.Controls.Add(nome);
                itemPanel.Controls.Add(descrizione);
                itemPanel.Controls.Add(prezzo);
                containerPanel.Controls.Add(itemPanel);
                colonna++;
                if (colonna >= columnCount)
                {
                    colonna = 0;
                    riga++;
                }
            }


        }



        private void OnMenuItemClick(Prodotto p)
        {
            DialogResult scelta=MessageBox.Show($"Hai selezionato:\n{p.Nome}\n{p.Nome}\nPrezzo: €{p.Prezzo:F2}\nAggiungerlo al carrello?","Menu McCadel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (scelta == DialogResult.Yes)
            {
                    Formhall.carrello.Add(p);
                    sala.Aggiornacarrello();

            }
        }

    }
}