namespace ClassLibraryMcCadel
{
    public class Magazzino(Ristorante ristorante)
    {
        static private Magazzino? magazzino;
        public Ristorante Ristorante { get; set; } = ristorante;
        public List<Prodotto> prodotti { get; set; } = [];
        private List<Ingrediente> ingredienti { get; set; } = [];


        public Magazzino(Ristorante ristorante, List<Prodotto> prodotti, List<Ingrediente> ingredienti) : this(ristorante)
        {
            this.prodotti = prodotti;
            this.ingredienti = ingredienti;
        }

        private static bool ControlloDisponibilità(Prodotto prodotto, List<Ingrediente>? necessari = null)
        {
            necessari ??= [];
            foreach (Ingrediente ingrediente in prodotto.Ingredienti)
            {
                necessari.Add(ingrediente);
                //Trova quanti ingredienti teorici ho già
                int conta = necessari.Count(necessari => necessari.Nome == ingrediente.Nome);

                if (ingrediente.Quantita < conta)
                {
                    //Se la quantità di ingredienti è minore a quella che ho, allora non ho disponibilità
                    return false;
                }
            }
            //Disponibilità approvata
            return true;
        }

        private static bool ControlloDisponibilità(Menu menu, List<Ingrediente>? necessari = null)
        {
            necessari ??= [];
            foreach (Prodotto prodotto in menu.Prodotti)
            {
                if (ControlloDisponibilità(prodotto, necessari) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /**
         * Controlla la disponibilità di un prodotto.
         * Se il prodotto o il menu non sono disponibili, ritorna false.
         * Altrimenti ritorna true se è stato prenotato dal magazzino.
         */
        public bool OrdinaProdotto(Prodotto prodotto)
        {
            if (ControlloDisponibilità(prodotto))
            {
                //Rimuovo gli ingredienti dal magazzino
                foreach (Ingrediente ingrediente in prodotto.Ingredienti)
                {
                    Ingrediente? ingredienteMagazzino = ingredienti.FirstOrDefault(i => i.Nome == ingrediente.Nome);
                    if (ingredienteMagazzino != null)
                    {
                        ingredienteMagazzino.Quantita--;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
         * Controlla la disponibilità di un menu.
         * Se il menu non è disponibile, ritorna false.
         * Altrimenti ritorna true se è stato prenotato dal magazzino.
         */
        public bool OrdinaMenu(Menu menu)
        {
            if (ControlloDisponibilità(menu))
            {
                //Rimuovo gli ingredienti dal magazzino
                foreach (Prodotto prodotto in menu.Prodotti)
                {
                    OrdinaProdotto(prodotto);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Rifornisci(Ingrediente ingrediente)
        {
            Ingrediente? ingredienteMagazzino = ingredienti.FirstOrDefault(i => i.Nome == ingrediente.Nome);
            if (ingredienteMagazzino != null)
            {
                // Se l'ingrediente esiste già, aggiorno la quantità
                ingredienteMagazzino.Quantita += ingrediente.Quantita;
            }
            else
            {
                // Altrimenti, aggiungo il nuovo ingrediente al magazzino
                ingredienti.Add(ingrediente);
            }
        }

        public void Rifornisci(List<Ingrediente> ingredienti)
        {
            foreach (Ingrediente ingrediente in ingredienti)
            {
                Rifornisci(ingrediente);
            }
        }
        static private Magazzino GetSampleData()
        {
            return new Magazzino(Ristorante.GetData()[0], Prodotto.GetData(), Ingrediente.GetData());
        }
        static public Magazzino GetData()
        {
            if (magazzino == null)
            {
                magazzino = GetSampleData();
            }
            return magazzino;
        }
    }
}
