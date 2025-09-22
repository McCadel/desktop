using System.Windows.Forms;

namespace WinFormsRistorante
{
    partial class FormAdmin
    {
        private DataGridView dgvDipendenti;
        private Button btnAggiungiDipendente;
        private TextBox txtNomeIngrediente;
        private TextBox txtQuantitaIngrediente;
        private Button btnAggiungiIngrediente;

        private void InitializeComponent()
        {
            dgvDipendenti = new DataGridView();
            btnAggiungiDipendente = new Button();
            btnRimuovi = new DataGridViewButtonColumn();
            btnModifica = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).BeginInit();
            SuspendLayout();
            // 
            // dgvDipendenti
            // 
            dgvDipendenti.Columns.AddRange(new DataGridViewColumn[] { btnRimuovi, btnModifica });
            dgvDipendenti.Location = new Point(12, 12);
            dgvDipendenti.Name = "dgvDipendenti";
            dgvDipendenti.Size = new Size(318, 150);
            dgvDipendenti.TabIndex = 0;
            dgvDipendenti.CellContentClick += dgvDipendenti_CellContentClick;
            // 
            // btnAggiungiDipendente
            // 
            btnAggiungiDipendente.Location = new Point(95, 207);
            btnAggiungiDipendente.Name = "btnAggiungiDipendente";
            btnAggiungiDipendente.Size = new Size(150, 29);
            btnAggiungiDipendente.TabIndex = 4;
            btnAggiungiDipendente.Text = "Aggiungi Dipendente";
            btnAggiungiDipendente.Click += btnAggiungiDipendente_Click;
            // 
            // btnRimuovi
            // 
            btnRimuovi.HeaderText = "Rimuovi";
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.ReadOnly = true;
            btnRimuovi.Text = "Rimuovi";
            // 
            // btnModifica
            // 
            btnModifica.HeaderText = "Modifica";
            btnModifica.Name = "btnModifica";
            btnModifica.ReadOnly = true;
            btnModifica.Text = "Modifica";
            btnModifica.UseColumnTextForButtonValue = true;
            // 
            // FormAdmin
            // 
            ClientSize = new Size(342, 265);
            Controls.Add(dgvDipendenti);
            Controls.Add(btnAggiungiDipendente);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).EndInit();
            ResumeLayout(false);
        }

        private void btnAggiungiDipendente_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private DataGridViewButtonColumn btnRimuovi;
        private DataGridViewButtonColumn btnModifica;
    }
}
