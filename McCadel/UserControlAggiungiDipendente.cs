using ClassLibraryMcCadel;
using System;
using System.Windows.Forms;

namespace WinFormsRistorante
{
    public partial class UserControlAggiungiDipendente : UserControl
    {
        public event Action<Dipendente>? DipendenteAggiunto;

        public UserControlAggiungiDipendente()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Inserisci Nome e Cognome", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double stipendio = (double)nudStipendio.Value;

            Dipendente nuovoDip = new Dipendente(textBox2.Text, textBox3.Text, stipendio);

            DipendenteAggiunto?.Invoke(nuovoDip);

            textBox2.Text = "";
            textBox3.Text = "";
            nudStipendio.Value = 1000;
        }

        private void UserControlAggiungiDipendente_Load(object sender, EventArgs e)
        {

        }
    }
}
