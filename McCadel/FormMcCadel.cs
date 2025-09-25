using WinFormsRistorante;

namespace McCadel
{
    public partial class FormMcCadel : Form
    {
        public FormMcCadel()
        {
            InitializeComponent();
        }
        private void bentra_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
             FormAdmin FormAdmin1 = new FormAdmin();
            FormAdmin1.Visible = true;

        }
    }
}
