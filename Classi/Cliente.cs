using System.ComponentModel;

namespace Classi
{
    public class Cliente(string nome, string cognome, Ristorante ristorante)
    {
        static private BindingList<Cliente>? clienti;
        public string Nome { get; set; } = nome;
        public string Cognome { get; set; } = cognome;
        public Ordine? Ordine { get; set; }
        public Ristorante Ristorante { get; set; } = ristorante;
        public void Ordina(int ntavolo, List<Prodotto> prodotti)
        {
            ristorante.Ordini.Add(Ordine = new Ordine(ntavolo, prodotti, Ristorante, this));
        }

        static private BindingList<Cliente> GetSampleData()
        {
            return  new BindingList<Cliente>()
                {
                    new Cliente("Cadel", "Evans", Ristorante.GetData()[0]),
                    new Cliente("Fausto", "Coppi", Ristorante.GetData()[0]),
                    new Cliente("Gino", "Bartali", Ristorante.GetData()[0])
                };
        }
        static public BindingList<Cliente> GetData()
        {
            if (clienti == null)
            {
                clienti=GetSampleData();
            }
            return clienti;
        }
    }
}
