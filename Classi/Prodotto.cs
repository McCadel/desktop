using System.ComponentModel;

namespace Classi
{
    public class Prodotto(string nome, double prezzo, List<Menu> menu, List<Ingrediente> ingredienti)
    {
        static private List<Prodotto>? prodotti;
        public string Nome { get; set; } = nome;
        public double Prezzo { get; set; } = prezzo;
        public List<Menu> menu { get; set; } = menu;
        public List<Ingrediente> Ingredienti { get; set; } = ingredienti;
        static private List<Prodotto> GetSampleData()
        {
            if (Menu.GetData()[0].Prodotti.Count == 0)
            {
                List<Ingrediente> hamburger = [];
                List<Ingrediente> cheeseburger = [];
                List<Ingrediente> patatine= [];
                List<Ingrediente> nuggets= [];
                foreach (Ingrediente s in Ingrediente.GetData())
                {
                    if (s.Nome == "Maionese")
                    {
                        hamburger.Add(s);
                        cheeseburger.Add(s);
                        patatine.Add(s);
                        nuggets.Add(s);
                    }
                    if(s.Nome =="Carne" || s.Nome=="Insalata" || s.Nome == "Pomodoro")
                    {
                        hamburger.Add(s);
                        cheeseburger.Add(s);
                    }
                    if (s.Nome == "Formaggio")
                    {
                        cheeseburger.Add(s);
                    }
                    if( s.Nome == "Patatine")
                    {
                        patatine.Add(s);
                    }
                    if (s.Nome == "Nuggets")
                    {
                        patatine.Add(s);
                    }
                }
                Menu menu = Menu.GetData()[0];
                return new List<Prodotto>()
                    {
                        new Prodotto("Hamburger", 12, new List<Menu>(){menu}, hamburger),
                        new Prodotto("Cheeseburger", 13, new List<Menu>(){menu}, cheeseburger),
                        new Prodotto("Nuggets", 6, new List<Menu>(){menu}, nuggets),
                        new Prodotto("Patatine", 5, new List<Menu>(){menu}, patatine),
                        new Prodotto("Coca cola", 3, new List<Menu>(){menu}, new List<Ingrediente>(){Ingrediente.GetData()[0]}),
                        new Prodotto("Fanta", 3, new List<Menu>(){menu}, new List<Ingrediente>(){Ingrediente.GetData()[1]})
                    };
            }
            return new List<Prodotto>();
        }
        static public List<Prodotto> GetData()
        {
            if (prodotti == null)
            {
                prodotti = GetSampleData();
            }
            return prodotti;
        }
    }
}
