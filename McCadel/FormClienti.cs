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
    public partial class FormClienti : Form
    {
        private Cliente cliente;
        public FormClienti()
        {
            InitializeComponent();
        }
        public FormClienti(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            tnome.Text = cliente.Nome;
            tcognome.Text = cliente.Cognome;
        }

        private void binserisci_Click(object sender, EventArgs e)
        {
            lerrore.Text = "";
            if (string.IsNullOrWhiteSpace(tnome.Text) || string.IsNullOrWhiteSpace(tcognome.Text))
            {
                lerrore.Text = "Errore, completare tutti i campi";
                return;
            }

            string nuovoNome = tnome.Text;
            string nuovoCognome = tcognome.Text;

            // Usa DataManager per salvare un cliente
            // await dataManager.SalvaClienteAsync(cliente);
            
            this.Close();
        }
    }
}