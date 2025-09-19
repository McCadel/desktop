namespace McCadel
{
    partial class FormCarrello
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
            lbTotalePrezzo = new Label();
            lbCarrelloVuoto = new Label();
            btnBack = new Button();
            tableProdottiCarrello = new TableLayoutPanel();
            panel1 = new Panel();
            bprocedi = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTotalePrezzo
            // 
            lbTotalePrezzo.AutoSize = true;
            lbTotalePrezzo.Location = new Point(706, 392);
            lbTotalePrezzo.Name = "lbTotalePrezzo";
            lbTotalePrezzo.Size = new Size(57, 15);
            lbTotalePrezzo.TabIndex = 1;
            lbTotalePrezzo.Text = "Totale: 0€";
            // 
            // lbCarrelloVuoto
            // 
            lbCarrelloVuoto.AutoSize = true;
            lbCarrelloVuoto.Location = new Point(362, 392);
            lbCarrelloVuoto.Name = "lbCarrelloVuoto";
            lbCarrelloVuoto.Size = new Size(98, 15);
            lbCarrelloVuoto.TabIndex = 2;
            lbCarrelloVuoto.Text = "Il carrello è vuoto";
            lbCarrelloVuoto.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(30, 376);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 47);
            btnBack.TabIndex = 3;
            btnBack.Text = "Torna all'ordinazione";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tableProdottiCarrello
            // 
            tableProdottiCarrello.AutoSize = true;
            tableProdottiCarrello.ColumnCount = 3;
            tableProdottiCarrello.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableProdottiCarrello.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableProdottiCarrello.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableProdottiCarrello.Location = new Point(25, 23);
            tableProdottiCarrello.Name = "tableProdottiCarrello";
            tableProdottiCarrello.RowCount = 1;
            tableProdottiCarrello.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableProdottiCarrello.Size = new Size(770, 57);
            tableProdottiCarrello.TabIndex = 0;
            tableProdottiCarrello.Paint += tableProdottiCarrello_Paint;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableProdottiCarrello);
            panel1.Location = new Point(2, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 362);
            panel1.TabIndex = 4;
            // 
            // bprocedi
            // 
            bprocedi.Location = new Point(172, 376);
            bprocedi.Name = "bprocedi";
            bprocedi.Size = new Size(133, 47);
            bprocedi.TabIndex = 5;
            bprocedi.Text = "Procedi";
            bprocedi.UseVisualStyleBackColor = true;
            bprocedi.Click += bprocedi_Click;
            // 
            // FormCarrello
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bprocedi);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(lbCarrelloVuoto);
            Controls.Add(lbTotalePrezzo);
            Name = "FormCarrello";
            Text = "Carrello";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbTotalePrezzo;
        private Label lbCarrelloVuoto;
        private Button btnBack;
        private TableLayoutPanel tableProdottiCarrello;
        private Panel panel1;
        private Button bprocedi;
    }
}