namespace ClassLibraryMcCadel
{
    public class Magazzino(Ristorante ristorante)
    {
        static private Magazzino? magazzino;
        public Ristorante Ristorante { get; set; } = ristorante;
        public List<Prodotto>? Prodotti { get; set; } = null;

        private List<Ingrediente> Ingredienti { get; set; } = [];


        public Magazzino(Ristorante ristorante, List<Ingrediente> ingredienti) : this(ristorante)
        {
            this.Ingredienti = ingredienti;
        }

        public Magazzino(Ristorante ristorante, List<Prodotto> prodotti, List<Ingrediente> ingredienti) : this(ristorante)
        {
            Prodotti = prodotti;
            this.Ingredienti = ingredienti;
        }

        /* Controlla la disponibilità di un prodotto.
         * Se il prodotto non è disponibile, ritorna false.
         * Altrimenti ritorna true.
         */
        private bool ControlloDisponibilità(Prodotto prodotto, List<Ingrediente>? necessari = null)
        {
            necessari ??= [];
            foreach (Ingrediente ingrediente in prodotto.Ingredienti)
            {
                necessari.Add(ingrediente);
                //Trova quanti ingredienti teorici ho già
                int conta = necessari.Count(necessari => necessari.Nome == ingrediente.Nome);

                Ingrediente? ingredienteMagazzino = Ingredienti.FirstOrDefault(i => i.Nome.ToLower() == ingrediente.Nome.ToLower());

                if (ingredienteMagazzino == null)
                {
                    //Neussun ingrediente nel magazzino registrato in questo modo
                    throw new Exception($"Ingrediente {ingrediente.Nome} non trovato nel magazzino. Magari non sarà stato aggiunto al magazzino");
                }

                if (ingredienteMagazzino.Quantita < conta)
                {
                    //Se la quantità di ingredienti è minore a quella che ho, allora non ho disponibilità
                    return false;
                }
            }
            //Disponibilità approvata
            return true;
        }

        /**
         * Controlla la disponibilità di un menu.
         * Se il menu non è disponibile, ritorna false.
         * Altrimenti ritorna true.
         */
        private bool ControlloDisponibilità(Menu menu, List<Ingrediente>? necessari = null)
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
         * Controlla la disponibilità di un ordine.
         * Se l'ordine non è disponibile, ritorna false.
         * Altrimenti ritorna true.
         */
        public bool ControlloDisponibilità(Ordine ordine, List<Ingrediente>? necessari = null)
        {
            necessari ??= [];
            foreach (Prodotto prodotto in ordine.Prodotti)
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
         * Se il prodotto non è disponibile, ritorna false.
         * Altrimenti ritorna true se è stato prenotato dal magazzino.
         */
        public bool OrdinaProdotto(Prodotto prodotto)
        {
            if (ControlloDisponibilità(prodotto))
            {
                //Rimuovo gli ingredienti dal magazzino
                foreach (Ingrediente ingrediente in prodotto.Ingredienti)
                {
                    Ingrediente? ingredienteMagazzino = Ingredienti.FirstOrDefault(i => i.Nome.ToLower() == ingrediente.Nome.ToLower());
                    if (ingredienteMagazzino != null)
                    {
                        ingredienteMagazzino.Quantita--;
                    }
                    else throw new Exception($"Ingrediente {ingrediente.Nome} non trovato nel magazzino. Magari non sarà stato aggiunto al magazzino");
                }
                SaveDataToJson();
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

        /**
         * Controlla la disponibilità di un ordine.
         * Se l'ordine non è disponibile, ritorna false.
         * Altrimenti ritorna true se è stato prenotato dal magazzino.
         */
        public bool OrdinaOrdine(Ordine ordine)
        {
            if (ControlloDisponibilità(ordine))
            {
                //Rimuovo gli ingredienti dal magazzino
                foreach (Prodotto prodotto in ordine.Prodotti)
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

        /**
         * Rifornisce il magazzino con un ingrediente.
         * Se l'ingrediente esiste già, aggiorna la quantità.
         * Altrimenti, aggiunge il nuovo ingrediente al magazzino.
         */
        public void Rifornisci(Ingrediente ingrediente)
        {
            Ingrediente? ingredienteMagazzino = Ingredienti.FirstOrDefault(i => i.Nome.ToLower() == ingrediente.Nome.ToLower());
            if (ingredienteMagazzino != null)
            {
                // Se l'ingrediente esiste già, aggiorno la quantità
                ingredienteMagazzino.Quantita += ingrediente.Quantita;
            }
            else
            {
                // Altrimenti, aggiungo il nuovo ingrediente al magazzino
                Ingredienti.Add(ingrediente);
            }
        }

        /**
         * Rifornisce il magazzino con una lista di ingredienti.
         * Se uno o più degli ingredienti esiste già, ne aggiorna la quantità.
         * Altrimenti, aggiunge il nuovo ingrediente al magazzino.
         */
        public void Rifornisci(List<Ingrediente> ingredienti)
        {
            foreach (Ingrediente ingrediente in ingredienti)
            {
                Rifornisci(ingrediente);
            }
        }

        public override string ToString()
        {
            string stringa = "Magazzino del ristorante " + Ristorante.Nome + ":\n";
            foreach (Ingrediente ingrediente in Ingredienti)
            {
                stringa += "- " + ingrediente + "\n";
            }
            return stringa;
        }
        static private Magazzino GetSampleData()
        {
            return new Magazzino(Ristorante.GetData()[0], Ingrediente.GetData());
        }
        static public Magazzino GetData()
        {
            if (magazzino == null)
            {
                magazzino = GetSampleData();
            }
            return magazzino;
        }


        private void SaveDataToJson()
        {
            Ingrediente.SaveDataToJson();
        }
    }
}
