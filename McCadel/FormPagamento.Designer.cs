namespace McCadel
{
    partial class FormPagamento
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
            lprezzo = new Label();
            lristorante = new Label();
            cristorante = new ComboBox();
            bristorante = new Button();
            lcliente = new Label();
            ccliente = new ComboBox();
            bcliente = new Button();
            baggiornar = new Button();
            baggiornac = new Button();
            beliminar = new Button();
            beliminac = new Button();
            bordina = new Button();
            ltavolo = new Label();
            ttavolo = new TextBox();
            lerrore = new Label();
            SuspendLayout();
            // 
            // ltitolo
            // 
            ltitolo.AutoSize = true;
            ltitolo.Font = new Font("Segoe UI Black", 20F);
            ltitolo.Location = new Point(307, 24);
            ltitolo.Name = "ltitolo";
            ltitolo.Size = new Size(168, 37);
            ltitolo.TabIndex = 0;
            ltitolo.Text = "Pagamento";
            // 
            // lprezzo
            // 
            lprezzo.AutoSize = true;
            lprezzo.Location = new Point(370, 63);
            lprezzo.Name = "lprezzo";
            lprezzo.Size = new Size(38, 15);
            lprezzo.TabIndex = 1;
            lprezzo.Text = "label1";
            // 
            // lristorante
            // 
            lristorante.AutoSize = true;
            lristorante.Font = new Font("Segoe UI Black", 20F);
            lristorante.Location = new Point(307, 97);
            lristorante.Name = "lristorante";
            lristorante.Size = new Size(154, 37);
            lristorante.TabIndex = 2;
            lristorante.Text = "Ristorante";
            // 
            // cristorante
            // 
            cristorante.FormattingEnabled = true;
            cristorante.Location = new Point(324, 147);
            cristorante.Name = "cristorante";
            cristorante.Size = new Size(121, 23);
            cristorante.TabIndex = 3;
            // 
            // bristorante
            // 
            bristorante.Font = new Font("Segoe UI", 9F);
            bristorante.Location = new Point(324, 176);
            bristorante.Name = "bristorante";
            bristorante.Size = new Size(121, 23);
            bristorante.TabIndex = 4;
            bristorante.Text = "Aggiungi ristorante";
            bristorante.UseVisualStyleBackColor = true;
            bristorante.Click += bristorante_Click;
            // 
            // lcliente
            // 
            lcliente.AutoSize = true;
            lcliente.Font = new Font("Segoe UI Black", 20F);
            lcliente.Location = new Point(307, 211);
            lcliente.Name = "lcliente";
            lcliente.Size = new Size(108, 37);
            lcliente.TabIndex = 5;
            lcliente.Text = "Cliente";
            // 
            // ccliente
            // 
            ccliente.FormattingEnabled = true;
            ccliente.Location = new Point(324, 251);
            ccliente.Name = "ccliente";
            ccliente.Size = new Size(121, 23);
            ccliente.TabIndex = 6;
            // 
            // bcliente
            // 
            bcliente.Font = new Font("Segoe UI", 9F);
            bcliente.Location = new Point(324, 280);
            bcliente.Name = "bcliente";
            bcliente.Size = new Size(121, 23);
            bcliente.TabIndex = 7;
            bcliente.Text = "Aggiungi cliente";
            bcliente.UseVisualStyleBackColor = true;
            bcliente.Click += bcliente_Click;
            // 
            // baggiornar
            // 
            baggiornar.Location = new Point(460, 146);
            baggiornar.Name = "baggiornar";
            baggiornar.Size = new Size(75, 23);
            baggiornar.TabIndex = 8;
            baggiornar.Text = "Aggiorna";
            baggiornar.UseVisualStyleBackColor = true;
            baggiornar.Click += baggiornar_Click;
            // 
            // baggiornac
            // 
            baggiornac.Location = new Point(460, 250);
            baggiornac.Name = "baggiornac";
            baggiornac.Size = new Size(75, 23);
            baggiornac.TabIndex = 9;
            baggiornac.Text = "Aggiorna";
            baggiornac.UseVisualStyleBackColor = true;
            baggiornac.Click += baggiornac_Click;
            // 
            // beliminar
            // 
            beliminar.Location = new Point(460, 176);
            beliminar.Name = "beliminar";
            beliminar.Size = new Size(75, 23);
            beliminar.TabIndex = 10;
            beliminar.Text = "Elimina";
            beliminar.UseVisualStyleBackColor = true;
            beliminar.Click += beliminar_Click;
            // 
            // beliminac
            // 
            beliminac.Location = new Point(460, 279);
            beliminac.Name = "beliminac";
            beliminac.Size = new Size(75, 23);
            beliminac.TabIndex = 11;
            beliminac.Text = "Elimina";
            beliminac.UseVisualStyleBackColor = true;
            beliminac.Click += beliminac_Click;
            // 
            // bordina
            // 
            bordina.Location = new Point(324, 393);
            bordina.Name = "bordina";
            bordina.Size = new Size(154, 36);
            bordina.TabIndex = 12;
            bordina.Text = "Ordina";
            bordina.UseVisualStyleBackColor = true;
            bordina.Click += bordina_Click;
            // 
            // ltavolo
            // 
            ltavolo.AutoSize = true;
            ltavolo.Font = new Font("Segoe UI Black", 20F);
            ltavolo.Location = new Point(307, 305);
            ltavolo.Name = "ltavolo";
            ltavolo.Size = new Size(218, 37);
            ltavolo.TabIndex = 13;
            ltavolo.Text = "Numero tavolo";
            // 
            // ttavolo
            // 
            ttavolo.Location = new Point(340, 345);
            ttavolo.Name = "ttavolo";
            ttavolo.Size = new Size(121, 23);
            ttavolo.TabIndex = 14;
            // 
            // lerrore
            // 
            lerrore.AutoSize = true;
            lerrore.ForeColor = Color.Red;
            lerrore.Location = new Point(324, 9);
            lerrore.Name = "lerrore";
            lerrore.Size = new Size(0, 15);
            lerrore.TabIndex = 15;
            // 
            // FormPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lerrore);
            Controls.Add(ttavolo);
            Controls.Add(ltavolo);
            Controls.Add(bordina);
            Controls.Add(beliminac);
            Controls.Add(beliminar);
            Controls.Add(baggiornac);
            Controls.Add(baggiornar);
            Controls.Add(bcliente);
            Controls.Add(ccliente);
            Controls.Add(lcliente);
            Controls.Add(bristorante);
            Controls.Add(cristorante);
            Controls.Add(lristorante);
            Controls.Add(lprezzo);
            Controls.Add(ltitolo);
            Name = "FormPagamento";
            Text = "FormPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ltitolo;
        private Label lprezzo;
        private Label lristorante;
        private ComboBox cristorante;
        private Button bristorante;
        private Label lcliente;
        private ComboBox ccliente;
        private Button bcliente;
        private Button baggiornar;
        private Button baggiornac;
        private Button beliminar;
        private Button beliminac;
        private Button bordina;
        private Label ltavolo;
        private TextBox ttavolo;
        private Label lerrore;
    }
}