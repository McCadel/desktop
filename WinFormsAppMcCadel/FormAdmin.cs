using Classi;
using System;
using System.Windows.Forms;
using WinFormsAppMcCadel;

namespace WinFormsRistorante
{
    public partial class FormAdmin : Form
    {
        private Ristorante ristorante;

        public FormAdmin(Ristorante ristorante)
        {
            this.ristorante = ristorante;
            InitializeComponent();
            dgvDipendenti.DataSource = Dipendente.GetData(ristorante);
            dgvIngredienti.DataSource = Ingrediente.GetData();
        }

        private void btnAggiungiIngrediente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeIngrediente.Text.Trim();
            if (int.TryParse(txtQuantitaIngrediente.Text, out int quantita) && !string.IsNullOrEmpty(nome))
            {
                Ingrediente.GetData().Add(new Ingrediente(nome, quantita));
                dgvIngredienti.Refresh();
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido e una quantità numerica.");
            }
        }

        private void btnApriCliente_Click(object sender, EventArgs e)
        {
            FormCliente clienteForm = new FormCliente();
            clienteForm.Show();
        }

        private void btnApriGestoreOrdini_Click(object sender, EventArgs e)
        {
            FormGestoreOrdini ordiniForm = new FormGestoreOrdini();
            ordiniForm.Show();
        }
    }
}
