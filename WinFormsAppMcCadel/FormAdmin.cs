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
            dgvDipendenti.DataSource = Dipendente.GetData();
        }

        private void dgvDipendenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dipendente dip = dgvDipendenti.Rows[e.RowIndex].DataBoundItem as Dipendente;
            if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnRimuovi")
            {
                if (dip != null)
                {
                    ristorante.Dipendenti.Remove(dip);

                    dgvDipendenti.DataSource = null;
                    dgvDipendenti.DataSource = Dipendente.GetData();
                }
            }
            else if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnModifica")
            {
                FormModifica mod = new FormModifica(dip);
            }
        }
    }
}
