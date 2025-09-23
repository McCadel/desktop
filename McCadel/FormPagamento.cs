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
using Classi.Services;

namespace McCadel
{
    public partial class FormPagamento : Form
    {
        private List<Prodotto> carrello;
        private List<Ristorante> ristoranti;
        private List<Cliente> clienti;
        
        public FormPagamento(List<Prodotto> carrello)
        {
            InitializeComponent();
            this.carrello = carrello;
            lprezzo.Text = "Totale: €" + Math.Round(aggiornaprezzo(), 2);
            aggiornadati();
        }
        
        public void aggiornadati()
        {
            lerrore.Text = "";
            ristoranti = new List<Ristorante>();
            clienti = new List<Cliente>();
            
            // Salva i dati usando DataManager
            // ristoranti = await dataManager.LoadRistorantiAsync();
            // clienti = await dataManager.LoadClientiAsync();
            
            cristorante.DisplayMember = "Nome";
            cristorante.DataSource = ristoranti;
            if (cristorante.SelectedItem != null)
            {
                baggiornar.Visible = true;
                beliminar.Visible = true;
            }
            else
            {
                baggiornar.Visible = false;
                beliminar.Visible = false;
            }
            
            ccliente.DisplayMember = "Nome";
            ccliente.DataSource = clienti;
            if (ccliente.SelectedItem != null)
            {
                baggiornac.Visible = true;
                beliminac.Visible = true;
            }
            else
            {
                baggiornac.Visible = false;
                beliminac.Visible = false;
            }
        }
        
        public double aggiornaprezzo()
        {
            double totale = 0;
            for (int i = 0; i < carrello.Count; i++)
            {
                totale += carrello[i].Prezzo;
            }
            return totale;
        }

        private void bristorante_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormRistorante().ShowDialog();
            aggiornadati();
            Visible = true;
        }

        private void baggiornar_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormRistorante((Ristorante)cristorante.SelectedItem).ShowDialog();
            aggiornadati();
            Visible = true;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            if (ristoranti != null && ristoranti.Count > 0 && ristoranti.Contains(cristorante.SelectedItem))
            {
                DialogResult scelta = MessageBox.Show($"Sicuro di eliminare questo ristorante?", "Sicuro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (scelta == DialogResult.Yes)
                {
                    ristoranti.Remove((Ristorante)cristorante.SelectedItem);
                    // Salva i dati usando DataManager
                    // await dataManager.SalvaRistorantiAsync(ristoranti);
                    aggiornadati();
                }
            }
        }

        private void beliminac_Click(object sender, EventArgs e)
        {
            if (clienti != null && clienti.Count > 0 && clienti.Contains(ccliente.SelectedItem))
            {
                DialogResult scelta = MessageBox.Show($"Sicuro di eliminare questo Cliente?", "Sicuro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (scelta == DialogResult.Yes)
                {
                    clienti.Remove((Cliente)ccliente.SelectedItem);
                    // Salva i dati usando DataManager
                    // await dataManager.SalvaClientiAsync(clienti);
                    aggiornadati();
                }
            }
        }

        private void bcliente_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormClienti().ShowDialog();
            aggiornadati();
            Visible = true;
        }

        private void baggiornac_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormClienti((Cliente)ccliente.SelectedItem).ShowDialog();
            aggiornadati();
            Visible = true;
        }

        private void bordina_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(ttavolo.Text, out int tavolo) || tavolo <= 0)
                {
                    lerrore.Text = "Errore, inserire un numero di tavolo valido";
                    return;
                }

                if (ccliente.SelectedItem != null && cristorante.SelectedItem != null)
                {
                    Cliente clienteSelezionato = (Cliente)ccliente.SelectedItem;
                    Ristorante ristoranteSelezionato = (Ristorante)cristorante.SelectedItem;
                    Ordine o = new Ordine(tavolo, this.carrello, ristoranteSelezionato, clienteSelezionato);
                    clienteSelezionato.Ordini.Add(o);
                    ristoranteSelezionato.Ordini.Add(o);
                    if (!ristoranteSelezionato.Clienti.Contains(clienteSelezionato))
                    {
                        ristoranteSelezionato.Clienti.Add(clienteSelezionato);
                    }
                    
                    // Salva i dati usando DataManager
                    // await dataManager.SalvaOrdineAsync(o);
                    // await dataManager.SalvaClienteAsync(clienteSelezionato);
                    // await dataManager.SalvaRistoranteAsync(ristoranteSelezionato);
                    
                    MessageBox.Show("Ordine inviato!", "Confermato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    lerrore.Text = "Errore, inserire tutti i dati (cliente e ristorante)";
                }
            }
            catch (Exception ex)
            {
                lerrore.Text = $"Si è verificato un errore: {ex.Message}";
            }
        }
    }
}