using ClassLibraryMcCadel;
using System;
using System.Windows.Forms;

namespace McCadel
{
    public partial class UserControlModDipAdmin : UserControl
    {
        private Dipendente dip;
        public event Action<Dipendente>? DipendenteModificato;

        public UserControlModDipAdmin()
        {
            InitializeComponent();
        }

        public void SetDipendente(Dipendente d)
        {
            dip = d;
            txtNome.Text = dip.Nome;
            txtCognome.Text = dip.Cognome;
            nudStipendio.Value = (decimal)dip.Stipendio;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dip == null) return;

            dip.Nome = txtNome.Text.Trim();
            dip.Cognome = txtCognome.Text.Trim();
            dip.Stipendio = (double)nudStipendio.Value;

            DipendenteModificato?.Invoke(dip);
            MessageBox.Show("Dipendente modificato!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserControlModDipAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
