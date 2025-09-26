using ClassLibraryMcCadel;
using McCadel;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsRistorante
{
    public partial class FormAdmin : Form
    {
        private Ristorante r;
        private string path = "../../Ristorante.json";

        public FormAdmin()
        {
            InitializeComponent();
            CaricaRistorante();
            InizializzaDgvDipendenti();
        }

        private void CaricaRistorante()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(json))
                    r = JsonSerializer.Deserialize<Ristorante>(json);
            }

            if (r == null)
            {
                r = new Ristorante("McCadel", "Via Roma");
                r.Dipendenti = Dipendente.GetData();
            }
        }

        private void InizializzaDgvDipendenti()
        {
            dgvDipendenti.AutoGenerateColumns = false;
            dgvDipendenti.Columns.Clear();

            dgvDipendenti.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnRimuovi",
                HeaderText = "Rimuovi",
                Text = "Rimuovi",
                UseColumnTextForButtonValue = true
            });

            dgvDipendenti.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnModifica",
                HeaderText = "Modifica",
                Text = "Modifica",
                UseColumnTextForButtonValue = true
            });

            dgvDipendenti.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });

            dgvDipendenti.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cognome",
                HeaderText = "Cognome"
            });

            dgvDipendenti.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stipendio",
                HeaderText = "Stipendio"
            });

            dgvDipendenti.DataSource = r.Dipendenti;
        }

        private void DgvDipendenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Dipendente dip = dgvDipendenti.Rows[e.RowIndex].DataBoundItem as Dipendente;
            if (dip == null) return;

            if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnRimuovi")
            {
                r.Dipendenti.Remove(dip);
                AggiornaGriglia();
                SalvaJson();
            }
            else if (dgvDipendenti.Columns[e.ColumnIndex].Name == "btnModifica")
            {
                using (FormModifica mod = new FormModifica(dip))
                {
                    if (mod.ShowDialog() == DialogResult.OK)
                    {
                        AggiornaGriglia();
                        SalvaJson();
                    }
                }
            }
        }

        private void AggiornaGriglia()
        {
            dgvDipendenti.DataSource = null;
            dgvDipendenti.DataSource = r.Dipendenti;
        }

        private void SalvaJson()
        {
            string json = JsonSerializer.Serialize(r, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        private void btnAggiungiDipendente_Click(object sender, EventArgs e)
        {
            using (FormAggiungiDipendente form = new FormAggiungiDipendente())
            {
                if (form.ShowDialog() == DialogResult.OK && form.NuovoDipendente != null)
                {
                    r.Dipendenti.Add(form.NuovoDipendente);
                    AggiornaGriglia();
                    SalvaJson();
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
