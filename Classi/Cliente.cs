namespace Classi
{
    public class Cliente(string nome, string cognome, Ristorante ristorante)
    {
        public string Nome { get; set; } = nome;
        public string Cognome { get; set; } = cognome;
        public Ordine? Ordine { get; set; }
        public Ristorante Ristorante { get; set; } = ristorante;
        public void Ordina(int ntavolo, List<Prodotto> prodotti)
        {
            ristorante.Ordini.Add(Ordine = new Ordine(ntavolo, prodotti, Ristorante, this));
        }
    }
}
