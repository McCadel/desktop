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
            button2 = new Button();
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
            // btnLoginAdmin
            // 
            btnLoginAdmin.Location = new Point(774, 652);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(116, 35);
            btnLoginAdmin.TabIndex = 1;
            btnLoginAdmin.Text = "Login Admin";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 652);
            button2.Name = "button2";
            button2.Size = new Size(116, 35);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormMcCadel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.entrata;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 709);
            Controls.Add(button2);
            Controls.Add(btnLoginAdmin);
            Controls.Add(bentra);
            Name = "FormMcCadel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "McCadel";
            ResumeLayout(false);
        }

        #endregion

        private Button bentra;
        private Button btnLoginAdmin;
        private Button button2;
    }
}
