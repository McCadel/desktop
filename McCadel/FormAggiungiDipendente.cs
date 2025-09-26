using ClassLibraryMcCadel;
using System;
using System.Windows.Forms;

namespace WinFormsRistorante
{
    public partial class FormAggiungiDipendente : Form
    {
        public Dipendente? NuovoDipendente { get; private set; }

        public FormAggiungiDipendente()
        {
            InitializeComponent();
            uca.DipendenteAggiunto += Uca_DipendenteAggiunto;
        }

        private void Uca_DipendenteAggiunto(Dipendente dip)
        {
            NuovoDipendente = dip;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormAggiungiDipendente_Load(object sender, EventArgs e)
        {

        }
    }
}
