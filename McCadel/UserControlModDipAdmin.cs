using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMcCadel;

namespace McCadel
{
    public partial class UserControlModDipAdmin : UserControl
    {
        private Dipendente dip;
        public UserControlModDipAdmin()
        {
            InitializeComponent();
        }

        public UserControlModDipAdmin(Dipendente d) : this()
        {
            InitializeComponent();
            dip = d;
            txtName.Text = d.Nome + d.Cognome;
            txtStipendio.Text = d.Stipendio.ToString();
        }

        private void btnModStipendio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStipendio.Text, out int nuovoStipendio))
            {
                dip.Stipendio = nuovoStipendio;
            }
        }
    }
}