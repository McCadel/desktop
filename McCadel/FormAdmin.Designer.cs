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
            btnRimuovi = new DataGridViewButtonColumn();
            btnModifica = new DataGridViewButtonColumn();
            btnAggiungiDipendente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).BeginInit();
            SuspendLayout();
            // 
            // dgvDipendenti
            // 
            dgvDipendenti.Columns.AddRange(new DataGridViewColumn[] { btnRimuovi, btnModifica });
            dgvDipendenti.Location = new Point(12, 12);
            dgvDipendenti.Name = "dgvDipendenti";
            dgvDipendenti.Size = new Size(881, 281);
            dgvDipendenti.TabIndex = 0;
            dgvDipendenti.CellContentClick += dgvDipendenti_CellContentClick;
            // 
            // btnRimuovi
            // 
            btnRimuovi.HeaderText = "Rimuovi";
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.ReadOnly = true;
            btnRimuovi.Text = "Rimuovi";
            btnRimuovi.UseColumnTextForButtonValue = true;
            // 
            // btnModifica
            // 
            btnModifica.HeaderText = "Modifica";
            btnModifica.Name = "btnModifica";
            btnModifica.ReadOnly = true;
            btnModifica.Text = "Modifica";
            btnModifica.UseColumnTextForButtonValue = true;
            // 
            // btnAggiungiDipendente
            // 
            btnAggiungiDipendente.Location = new Point(280, 340);
            btnAggiungiDipendente.Name = "btnAggiungiDipendente";
            btnAggiungiDipendente.Size = new Size(282, 73);
            btnAggiungiDipendente.TabIndex = 4;
            btnAggiungiDipendente.Text = "Aggiungi Dipendente";
            btnAggiungiDipendente.Click += btnAggiungiDipendente_Click;
            // 
            // FormAdmin
            // 
            ClientSize = new Size(910, 450);
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