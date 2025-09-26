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
            btnLoginAdmin = new Button();
            SuspendLayout();
            // 
            // bentra
            // 
            bentra.Location = new Point(479, 677);
            bentra.Margin = new Padding(3, 4, 3, 4);
            bentra.Name = "bentra";
            bentra.Size = new Size(86, 31);
            bentra.TabIndex = 0;
            bentra.Text = "Entra";
            bentra.UseVisualStyleBackColor = true;
            bentra.Click += bentra_click;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(12, 4);
            btnLoginAdmin.Margin = new Padding(3, 4, 3, 4);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(133, 47);
            btnLoginAdmin.TabIndex = 1;
            btnLoginAdmin.Text = "Login Admin";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // FormMcCadel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.entrata;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 945);
            Controls.Add(btnLoginAdmin);
            Controls.Add(bentra);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMcCadel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "McCadel";
            ResumeLayout(false);
        }

        #endregion

        private Button bentra;
        private Button btnLoginAdmin;
    }
}
