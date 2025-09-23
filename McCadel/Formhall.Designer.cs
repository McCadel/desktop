namespace McCadel
{
    partial class Formhall
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

            pCadel = new PictureBox();
            ltotem = new Label();
            userControlSezioni = new UserControlSezioni(this);
            userControlMenu = new UserControlMenu(this);
            menu = new Label();

            // Dichiarazione del nuovo bottone
            btnBottomCenter = new Button();

            ((System.ComponentModel.ISupportInitialize)pCadel).BeginInit();
            SuspendLayout();
            // 
            // pCadel
            // 
            pCadel.BackgroundImage = Properties.Resources.Cadel;
            pCadel.BackgroundImageLayout = ImageLayout.Stretch;
            pCadel.BorderStyle = BorderStyle.FixedSingle;
            pCadel.Location = new Point(-4, 0);
            pCadel.Name = "pCadel";
            pCadel.Size = new Size(517, 709);
            pCadel.TabIndex = 0;
            pCadel.TabStop = false;
            // 
            // ltotem
            // 
            ltotem.AutoSize = true;
            ltotem.Font = new Font("Segoe UI Black", 17F);
            ltotem.Location = new Point(645, 9);
            ltotem.Name = "ltotem";
            ltotem.Size = new Size(110, 31);
            ltotem.TabIndex = 2;
            ltotem.Text = "McCadel";
            // 
            // userControlSezioni
            // 
            userControlSezioni.Location = new Point(517, 90);
            userControlSezioni.Name = "userControlSezioni1";
            userControlSezioni.Size = new Size(152, 550);
            userControlSezioni.TabIndex = 3;
            // 
            // userControlMenu
            // 
            userControlMenu.Location = new Point(666, 90);
            userControlMenu.Name = "userControlMenu1";
            userControlMenu.Size = new Size(252, 550);
            userControlMenu.TabIndex = 4;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Font = new Font("Segoe Print", 20F);
            menu.Location = new Point(645, 40);
            menu.Name = "menu";
            menu.Size = new Size(94, 47); 
            menu.TabIndex = 5;
            menu.Text = "Menu";
            //
            // btnBottomCenter
            //
            btnBottomCenter.Location = new Point(0, 0);
            btnBottomCenter.Name = "btnBottomCenter";
            btnBottomCenter.Size = new Size(120, 40);
            btnBottomCenter.TabIndex = 6;
            btnBottomCenter.UseVisualStyleBackColor = true;
            btnBottomCenter.Click += btnCklick;
            int buttonX = (1450 - btnBottomCenter.Width) / 2;
            int buttonY = 709 - btnBottomCenter.Height - 20; 
            btnBottomCenter.Location = new Point(buttonX, buttonY);
            // 
            // Formhall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 709);
            Controls.Add(btnBottomCenter);
            Controls.Add(menu);
            Controls.Add(userControlMenu);
            Controls.Add(userControlSezioni);
            Controls.Add(ltotem);
            Controls.Add(pCadel);

            Name = "Formhall";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formhall";
            ((System.ComponentModel.ISupportInitialize)pCadel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pCadel;
        private Label ltotem;
        private UserControlSezioni userControlSezioni;
        private UserControlMenu userControlMenu;
        private Label menu;
        private Button btnBottomCenter;

        public UserControlSezioni UserControlSezioni { get => userControlSezioni; set => userControlSezioni = value; }
        public UserControlMenu UserControlMenu { get => userControlMenu; set => userControlMenu = value; }
    }
}