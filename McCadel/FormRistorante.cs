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
//using Classi.Services;

namespace McCadel
{
    public partial class FormRistorante : Form
    {
        Ristorante r;
        public FormRistorante()
        {
            InitializeComponent();
        }
        public FormRistorante(Ristorante r)
        {
            InitializeComponent();
            this.r = r;
            tnome.Text = r.Nome;
            tindirizzo.Text = r.Indirizzo;
        }

        private void bfine_Click(object sender, EventArgs e)
        {
            lerrore.Text = "";
            string nuovoNome = tnome.Text;
            string nuovoIndirizzo = tindirizzo.Text;
            if (string.IsNullOrWhiteSpace(nuovoNome) || string.IsNullOrWhiteSpace(nuovoIndirizzo))
            {
                lerrore.Text = "Errore, completare tutti i campi";
                return;
            }

            try
            {
                // Usa DataManager per salvare i dati
                // await dataManager.SalvaRistoranteAsync(ristorante);
                
                this.Close();
            }
            catch (Exception ex)
            {
                lerrore.Text = $"Errore: {ex.Message}";
            }
        }
    }
}