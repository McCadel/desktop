using System.Drawing;
using System.Windows.Forms;

namespace McCadel
{
    partial class UserControlModDipAdmin
    {
        private Label lblNome;
        private Label lblCognome;
        private Label lblStipendio;
        private TextBox txtNome;
        private TextBox txtCognome;
        private NumericUpDown nudStipendio;
        private Button btnModifica;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCognome = new Label();
            lblStipendio = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            nudStipendio = new NumericUpDown();
            btnModifica = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStipendio).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(20, 60);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(60, 15);
            lblCognome.TabIndex = 2;
            lblCognome.Text = "Cognome";
            // 
            // lblStipendio
            // 
            lblStipendio.AutoSize = true;
            lblStipendio.Location = new Point(20, 100);
            lblStipendio.Name = "lblStipendio";
            lblStipendio.Size = new Size(57, 15);
            lblStipendio.TabIndex = 4;
            lblStipendio.Text = "Stipendio";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(100, 57);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(150, 23);
            txtCognome.TabIndex = 3;
            // 
            // nudStipendio
            // 
            nudStipendio.Location = new Point(100, 98);
            nudStipendio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStipendio.Name = "nudStipendio";
            nudStipendio.Size = new Size(120, 23);
            nudStipendio.TabIndex = 5;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(60, 140);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 30);
            btnModifica.TabIndex = 6;
            btnModifica.Text = "Modifica Dipendente";
            btnModifica.Click += btnModifica_Click;
            // 
            // UserControlModDipAdmin
            // 
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCognome);
            Controls.Add(txtCognome);
            Controls.Add(lblStipendio);
            Controls.Add(nudStipendio);
            Controls.Add(btnModifica);
            Name = "UserControlModDipAdmin";
            Size = new Size(280, 190);
            Load += UserControlModDipAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)nudStipendio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
