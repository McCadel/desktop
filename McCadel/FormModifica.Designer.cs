using System;
using System.Windows.Forms;

namespace McCadel
{
    partial class FormModifica
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            userControlModDipAdmin2 = new UserControlModDipAdmin();
            SuspendLayout();
            // 
            // userControlModDipAdmin2
            // 
            userControlModDipAdmin2.Location = new Point(10, 10);
            userControlModDipAdmin2.Name = "userControlModDipAdmin2";
            userControlModDipAdmin2.Size = new Size(280, 200);
            userControlModDipAdmin2.TabIndex = 0;
            userControlModDipAdmin2.Load += userControlModDipAdmin2_Load;
            // 
            // FormModifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 220);
            Controls.Add(userControlModDipAdmin2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormModifica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifica Dipendente";
            Load += FormModifica_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControlModDipAdmin userControlModDipAdmin2;
    }
}
