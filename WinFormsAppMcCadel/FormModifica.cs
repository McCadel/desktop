using Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMcCadel
{
    public partial class FormModifica : Form
    {
        public FormModifica(Dipendente d)
        {
            InitializeComponent();
            UserControlModDipAdmin u = new UserControlModDipAdmin(d);
        }
    }
}
