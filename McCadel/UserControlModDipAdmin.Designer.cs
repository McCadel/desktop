using System.Windows.Forms;
using System.Xml.Linq;

namespace McCadel
{
    partial class UserControlModDipAdmin
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            lblNameDip = new Label();
            lblStipendio = new Label();
            txtName = new TextBox();
            txtStipendio = new TextBox();
            btnModStipendio = new Button();
            SuspendLayout();
            // 
            // lblNameDip
            // 
            lblNameDip.AutoSize = true;
            lblNameDip.Location = new Point(34, 35);
            lblNameDip.Name = "lblNameDip";
            lblNameDip.Size = new Size(68, 15);
            lblNameDip.TabIndex = 0;
            lblNameDip.Text = "Dipendente";
            // 
            // lblStipendio
            // 
            lblStipendio.AutoSize = true;
            lblStipendio.Location = new Point(34, 97);
            lblStipendio.Name = "lblStipendio";
            lblStipendio.Size = new Size(57, 15);
            lblStipendio.TabIndex = 1;
            lblStipendio.Text = "Stipendio";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 35);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtStipendio
            // 
            txtStipendio.Location = new Point(153, 94);
            txtStipendio.Name = "txtStipendio";
            txtStipendio.Size = new Size(100, 23);
            txtStipendio.TabIndex = 3;
            // 
            // btnModStipendio
            // 
            btnModStipendio.Location = new Point(70, 158);
            btnModStipendio.Name = "btnModStipendio";
            btnModStipendio.Size = new Size(136, 31);
            btnModStipendio.TabIndex = 4;
            btnModStipendio.Text = "Modifica Stipendio";
            btnModStipendio.UseVisualStyleBackColor = true;
            btnModStipendio.Click += btnModStipendio_Click;
            // 
            // UserControlModDipAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnModStipendio);
            Controls.Add(txtStipendio);
            Controls.Add(txtName);
            Controls.Add(lblStipendio);
            Controls.Add(lblNameDip);
            Name = "UserControlModDipAdmin";
            Size = new Size(274, 214);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameDip;
        private Label lblStipendio;
        private TextBox txtName;
        private TextBox txtStipendio;
        private Button btnModStipendio;
    }
}