using System.Windows.Forms;
using System.Drawing;

namespace WinFormsRistorante
{
    partial class FormAggiungiDipendente
    {
        private UserControlAggiungiDipendente uca;

        private void InitializeComponent()
        {
            uca = new UserControlAggiungiDipendente();
            SuspendLayout();
            // 
            // uca
            // 
            uca.Location = new Point(0, 0);
            uca.Name = "uca";
            uca.Size = new Size(308, 259);
            uca.TabIndex = 0;
            // 
            // FormAggiungiDipendente
            // 
            ClientSize = new Size(340, 250);
            Controls.Add(uca);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAggiungiDipendente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aggiungi Dipendente";
            Load += FormAggiungiDipendente_Load;
            ResumeLayout(false);
        }
    }
}
