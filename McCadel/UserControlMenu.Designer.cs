namespace McCadel
{
    partial class UserControlMenu
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
            tmenu = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tmenu
            // 
            tmenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tmenu.ColumnCount = 3;
            tmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tmenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tmenu.Location = new Point(0, 99);
            tmenu.Margin = new Padding(3, 4, 3, 4);
            tmenu.Name = "tmenu";
            tmenu.RowCount = 2;
            tmenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tmenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tmenu.Size = new Size(288, 147);
            tmenu.TabIndex = 1;
            // 
            // UserControlMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tmenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlMenu";
            Size = new Size(288, 888);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tmenu;
    }
}
