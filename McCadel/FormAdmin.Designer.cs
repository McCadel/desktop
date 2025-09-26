using System.Drawing;
using System.Windows.Forms;

namespace WinFormsRistorante
{
    partial class FormAdmin
    {
        private DataGridView dgvDipendenti;
        private Button btnAggiungiDipendente;

        private void InitializeComponent()
        {
            dgvDipendenti = new DataGridView();
            btnAggiungiDipendente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).BeginInit();
            SuspendLayout();
            // 
            // dgvDipendenti
            // 
            dgvDipendenti.Location = new Point(12, 12);
            dgvDipendenti.Name = "dgvDipendenti";
            dgvDipendenti.Size = new Size(560, 250);
            dgvDipendenti.TabIndex = 0;
            dgvDipendenti.CellContentClick += DgvDipendenti_CellContentClick;
            // 
            // btnAggiungiDipendente
            // 
            btnAggiungiDipendente.Location = new Point(180, 280);
            btnAggiungiDipendente.Name = "btnAggiungiDipendente";
            btnAggiungiDipendente.Size = new Size(200, 40);
            btnAggiungiDipendente.TabIndex = 1;
            btnAggiungiDipendente.Text = "Aggiungi Dipendente";
            btnAggiungiDipendente.Click += btnAggiungiDipendente_Click;
            // 
            // FormAdmin
            // 
            ClientSize = new Size(600, 350);
            Controls.Add(dgvDipendenti);
            Controls.Add(btnAggiungiDipendente);
            Name = "FormAdmin";
            Text = "Amministrazione Dipendenti";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDipendenti).EndInit();
            ResumeLayout(false);
        }
    }
}
