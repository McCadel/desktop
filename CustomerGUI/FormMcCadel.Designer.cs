namespace McCadel
{
    partial class FormMcCadel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bentra = new Button();
            SuspendLayout();
            // 
            // bentra
            // 
            bentra.Location = new Point(419, 508);
            bentra.Name = "bentra";
            bentra.Size = new Size(75, 23);
            bentra.TabIndex = 0;
            bentra.Text = "Entra";
            bentra.UseVisualStyleBackColor = true;
            bentra.Click += bentra_click;
            // 
            // FormMcCadel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.entrata;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 709);
            Controls.Add(bentra);
            Name = "FormMcCadel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "McCadel";
            ResumeLayout(false);
        }

        #endregion

        private Button bentra;
    }
}
