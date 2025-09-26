using System.Drawing;
using System.Windows.Forms;

namespace WinFormsRistorante
{
    partial class UserControlAggiungiDipendente
    {

        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelNome = new Label();
            labelCognome = new Label();
            labelStipendio = new Label();
            btnAggiungi = new Button();
            nudStipendio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudStipendio).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(70, 35);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // labelCognome
            // 
            labelCognome.AutoSize = true;
            labelCognome.Location = new Point(50, 91);
            labelCognome.Name = "labelCognome";
            labelCognome.Size = new Size(60, 15);
            labelCognome.TabIndex = 5;
            labelCognome.Text = "Cognome";
            // 
            // labelStipendio
            // 
            labelStipendio.AutoSize = true;
            labelStipendio.Location = new Point(53, 142);
            labelStipendio.Name = "labelStipendio";
            labelStipendio.Size = new Size(57, 15);
            labelStipendio.TabIndex = 7;
            labelStipendio.Text = "Stipendio";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(116, 201);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 8;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // nudStipendio
            // 
            nudStipendio.Location = new Point(116, 140);
            nudStipendio.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudStipendio.Name = "nudStipendio";
            nudStipendio.Size = new Size(120, 23);
            nudStipendio.TabIndex = 9;
            nudStipendio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // UserControlAggiungiDipendente
            // 
            Controls.Add(nudStipendio);
            Controls.Add(btnAggiungi);
            Controls.Add(labelStipendio);
            Controls.Add(labelCognome);
            Controls.Add(labelNome);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "UserControlAggiungiDipendente";
            Size = new Size(308, 259);
            Load += UserControlAggiungiDipendente_Load;
            ((System.ComponentModel.ISupportInitialize)nudStipendio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelNome;
        private Label labelCognome;
        private Label labelStipendio;
        private Button btnAggiungi;
        private NumericUpDown nudStipendio;
    }
}
