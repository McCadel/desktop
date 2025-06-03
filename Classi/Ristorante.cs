namespace Classi
{
    public class Ristorante
    {
        private string nome;
        private string indirizzo;
        private List<Dipendente> dipendenti;
        private List<Ordine> ordini;
        private List<Cliente> clienti;

        public Ristorante(string nome, string indirizzo)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.dipendenti = [];
            this.ordini = [];
            this.clienti = [];
        }
        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public List<Dipendente> Dipendenti { get => dipendenti; set => dipendenti = value; }
        public List<Ordine> Ordini { get => ordini; set => ordini = value; }
        public List<Cliente> Clienti { get => clienti; set => clienti = value; }
    }
}
