namespace Classi
{
    public class Ordine(int numeroTavolo, List<Prodotto> prodotti, Ristorante ristorante, Cliente cliente)
    {
        private List<Prodotto> prodotti = prodotti;

        public int NumeroTavolo { get; set; } = numeroTavolo;
        public Ristorante Ristorante { get; set; } = ristorante;
        public Cliente Cliente { get; set; } = cliente;

        public double CalcolaPrezzo()
        {
            double prezzo = 0;
            foreach(Prodotto p in prodotti){
                prezzo += p.Prezzo;
            }
            return prezzo;
        }
    }
}
