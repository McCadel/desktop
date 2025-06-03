namespace Classi
{
    public class Ristorante(string nome, string indirizzo)
    {
        public string Nome { get; set; } = nome;
        public string Indirizzo { get; set; } = indirizzo;
        public List<Dipendente> Dipendenti { get; set; } = [];
        public List<Ordine> Ordini { get; set; } = [];
        public List<Cliente> Clienti { get; set; } = [];
    }
}
