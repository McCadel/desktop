namespace McCadel
{
    partial class FormRistorante
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
            lindirizzo = new Label();
            tnome = new TextBox();
            tindirizzo = new TextBox();
            bfine = new Button();
            lerrore = new Label();
            SuspendLayout();
            // 
            // ltitolo
            // 
            ltitolo.AutoSize = true;
            ltitolo.Font = new Font("Segoe UI Black", 20F);
            ltitolo.Location = new Point(310, 9);
            ltitolo.Name = "ltitolo";
            ltitolo.Size = new Size(154, 37);
            ltitolo.TabIndex = 0;
            ltitolo.Text = "Ristorante";
            // 
            // lnome
            // 
            lnome.AutoSize = true;
            lnome.Location = new Point(310, 93);
            lnome.Name = "lnome";
            lnome.Size = new Size(43, 15);
            lnome.TabIndex = 1;
            lnome.Text = "Nome:";
            // 
            // lindirizzo
            // 
            lindirizzo.AutoSize = true;
            lindirizzo.Location = new Point(310, 145);
            lindirizzo.Name = "lindirizzo";
            lindirizzo.Size = new Size(57, 15);
            lindirizzo.TabIndex = 2;
            lindirizzo.Text = "Indirizzo: ";
            // 
            // tnome
            // 
            tnome.Location = new Point(385, 90);
            tnome.Name = "tnome";
            tnome.Size = new Size(100, 23);
            tnome.TabIndex = 3;
            // 
            // tindirizzo
            // 
            tindirizzo.Location = new Point(385, 142);
            tindirizzo.Name = "tindirizzo";
            tindirizzo.Size = new Size(100, 23);
            tindirizzo.TabIndex = 4;
            // 
            // bfine
            // 
            bfine.Location = new Point(365, 297);
            bfine.Name = "bfine";
            bfine.Size = new Size(75, 23);
            bfine.TabIndex = 5;
            bfine.Text = "Inserisci";
            bfine.UseVisualStyleBackColor = true;
            bfine.Click += bfine_Click;
            // 
            // lerrore
            // 
            lerrore.AutoSize = true;
            lerrore.ForeColor = Color.Red;
            lerrore.Location = new Point(310, 58);
            lerrore.Name = "lerrore";
            lerrore.Size = new Size(0, 15);
            lerrore.TabIndex = 6;
            // 
            // FormRistorante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lerrore);
            Controls.Add(bfine);
            Controls.Add(tindirizzo);
            Controls.Add(tnome);
            Controls.Add(lindirizzo);
            Controls.Add(lnome);
            Controls.Add(ltitolo);
            Name = "FormRistorante";
            Text = "FormRistorante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ltitolo;
        private Label lnome;
        private Label lindirizzo;
        private TextBox tnome;
        private TextBox tindirizzo;
        private Button bfine;
        private Label lerrore;
    }
}