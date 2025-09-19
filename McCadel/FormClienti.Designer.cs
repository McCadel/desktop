namespace McCadel
{
    partial class FormClienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ltitolo = new Label();
            lnome = new Label();
            tnome = new TextBox();
            lcognome = new Label();
            tcognome = new TextBox();
            binserisci = new Button();
            lerrore = new Label();
            SuspendLayout();
            // 
            // ltitolo
            // 
            ltitolo.AutoSize = true;
            ltitolo.Font = new Font("Segoe UI Black", 20F);
            ltitolo.Location = new Point(301, 9);
            ltitolo.Name = "ltitolo";
            ltitolo.Size = new Size(108, 37);
            ltitolo.TabIndex = 1;
            ltitolo.Text = "Cliente";
            // 
            // lnome
            // 
            lnome.AutoSize = true;
            lnome.Location = new Point(301, 85);
            lnome.Name = "lnome";
            lnome.Size = new Size(43, 15);
            lnome.TabIndex = 2;
            lnome.Text = "Nome:";
            // 
            // tnome
            // 
            tnome.Location = new Point(383, 82);
            tnome.Name = "tnome";
            tnome.Size = new Size(100, 23);
            tnome.TabIndex = 4;
            // 
            // lcognome
            // 
            lcognome.AutoSize = true;
            lcognome.Location = new Point(301, 137);
            lcognome.Name = "lcognome";
            lcognome.Size = new Size(66, 15);
            lcognome.TabIndex = 5;
            lcognome.Text = "Cognome: ";
            // 
            // tcognome
            // 
            tcognome.Location = new Point(383, 134);
            tcognome.Name = "tcognome";
            tcognome.Size = new Size(100, 23);
            tcognome.TabIndex = 6;
            // 
            // binserisci
            // 
            binserisci.Location = new Point(332, 357);
            binserisci.Name = "binserisci";
            binserisci.Size = new Size(106, 23);
            binserisci.TabIndex = 7;
            binserisci.Text = "Inserisci ";
            binserisci.UseVisualStyleBackColor = true;
            binserisci.Click += binserisci_Click;
            // 
            // lerrore
            // 
            lerrore.AutoSize = true;
            lerrore.ForeColor = Color.Red;
            lerrore.Location = new Point(301, 55);
            lerrore.Name = "lerrore";
            lerrore.Size = new Size(0, 15);
            lerrore.TabIndex = 8;
            // 
            // FormClienti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lerrore);
            Controls.Add(binserisci);
            Controls.Add(tcognome);
            Controls.Add(lcognome);
            Controls.Add(tnome);
            Controls.Add(lnome);
            Controls.Add(ltitolo);
            Name = "FormClienti";
            Text = "FormClienti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ltitolo;
        private Label lnome;
        private TextBox tnome;
        private Label lcognome;
        private TextBox tcognome;
        private Button binserisci;
        private Label lerrore;
    }
}