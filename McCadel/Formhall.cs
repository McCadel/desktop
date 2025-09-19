using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCadel
{
    public partial class Formhall : Form
    {
        public static List<Prodotto> carrello=new List<Prodotto>();
        public Formhall()
        {
            InitializeComponent();
            this.Visible = false;
            new FormMcCadel().ShowDialog();
            this.Visible = true;
            btnBottomCenter.Text = "Elementi nel carrello: " + carrello.Count;
        }
        public void Aggiornacarrello()
        {
            btnBottomCenter.Text = "Elementi nel carrello: " + carrello.Count;
            this.Refresh();
        }

        private void btnCklick(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormCarrello(carrello).ShowDialog();
            Aggiornacarrello();
            this.Visible = true;
        }
    }
}
