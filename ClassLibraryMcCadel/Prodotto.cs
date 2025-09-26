namespace ClassLibraryMcCadel
{
    public class Prodotto
    {
        private string nome;
        private string descrizione;
        private double prezzo;
        private List<Ingrediente> ingredienti = new List<Ingrediente>();

        static private List<Prodotto>? prodotti;

        public Prodotto(string nome, string descrizione, double prezzo)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }

        public Prodotto(string nome, double prezzo, List<Ingrediente> ingredienti, string descrizione)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.ingredienti = ingredienti;
            this.descrizione = descrizione;
        }

        public void addingrediente(Ingrediente i)
        {
            ingredienti.Add(i);
        }
        public void remingrediente(Ingrediente i)
        {
            ingredienti.Remove(i);
        }

        public string Nome { get => nome; set => nome = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public List<Ingrediente> Ingredienti { get => ingredienti; set => ingredienti = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }

        // --- Metodi richiesti ---
        static private List<Prodotto> GetSampleData()
        {
            // Recupero lista ingredienti già definita
            var ingredienti = Ingrediente.GetData();

            return new List<Prodotto>()
            {
                new Prodotto("Hamburger", 5.50,
                    new List<Ingrediente>() { ingredienti[2], ingredienti[3], ingredienti[4], ingredienti[6] },
                    "Panino con carne, insalata, pomodoro e formaggio"),

                new Prodotto("Patatine Fritte", 2.50,
                    new List<Ingrediente>() { ingredienti[7] },
                    "Patatine fritte croccanti"),

                new Prodotto("Nuggets", 3.00,
                    new List<Ingrediente>() { ingredienti[8] },
                    "Bocconcini di pollo fritti"),

                new Prodotto("Coca Cola", 1.50,
                    new List<Ingrediente>() { ingredienti[0] },
                    "Bibita gassata classica"),

                new Prodotto("Fanta", 1.50,
                    new List<Ingrediente>() { ingredienti[1] },
                    "Bibita gassata all'arancia")
            };
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
