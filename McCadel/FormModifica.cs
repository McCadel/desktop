using ClassLibraryMcCadel;
using System;
using System.Windows.Forms;

namespace McCadel
{
    public partial class FormModifica : Form
    {
        private Dipendente dip;

        public FormModifica(Dipendente d)
        {
            InitializeComponent();
            dip = d;
        }

        private void FormModifica_Load(object sender, EventArgs e)
        {
            userControlModDipAdmin2.SetDipendente(dip);
            userControlModDipAdmin2.DipendenteModificato += (modDip) =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }

        private void userControlModDipAdmin2_Load(object sender, EventArgs e)
        {

        }
    }
}
