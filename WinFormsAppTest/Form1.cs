using ClassLibraryMcCadel;

namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            List<Ingrediente> ingredienti = Ingrediente.GetData();
            dataGridViewMagazzino.DataSource = ingredienti;

            Magazzino magazzino = Magazzino.GetData();

            Prodotto p = new Prodotto("Hamburger", 5.00,  new List<Ingrediente>()
            {
                new Ingrediente("Carne", 1),
                new Ingrediente("Insalata", 1),
                new Ingrediente("Pomodoro", 1),
                new Ingrediente("Maionese", 1),
                new Ingrediente("Formaggio", 1),
                new Ingrediente("Patatine", 1)
            }, "Hamburger Classico");


            bool result = magazzino.OrdinaProdotto(p);

            if (result)
            {
                MessageBox.Show("Ordine effettuato con successo!");
            }
            else
            {
                MessageBox.Show("I prodotti sono salvati in magazzino, ma almeno uno necessario è esaurito!");
            }
        }
    }
}
