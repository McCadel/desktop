using ClassLibraryMcCadel;
using System;
using System.Windows.Forms;
using McCadel;

namespace WinFormsRistorante
{
    public partial class FormAdmin : Form
    {
        private Ristorante r;
        private String path;
        public FormAdmin()
        {
            InitializeComponent();
            this.path = "C:\\Users\\diego\\source\\repos\\desktop\\McCadel\\Ristorante.json";
            this.r = System.Text.Json.JsonSerializer.Deserialize<Ristorante>(System.IO.File.ReadAllText(path));
            if (r != null) dgvDipendenti.DataSource = r.Dipendenti;
        }

        private void dgvDipendenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dipendente dip = dgvDipendenti.Rows[e.RowIndex].DataBoundItem as Dipendente;
            if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnRimuovi")
            {
                if (dip != null)
                {
                    r.Dipendenti.Remove(dip);

                    // Aggiorna la DataGridView
                    dgvDipendenti.DataSource = null;
                    dgvDipendenti.DataSource = r.Dipendenti;

                    string json = System.Text.Json.JsonSerializer.Serialize(r);
                    System.IO.File.WriteAllText(path, json);
                }
            }
            else if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnModifica")
            {
                FormModifica mod = new FormModifica(dip);
                mod.Visible = true;
            }
        }
    }
}