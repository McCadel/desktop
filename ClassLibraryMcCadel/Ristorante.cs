using System.ComponentModel;

namespace ClassLibraryMcCadel
{
    public class Ristorante
    {
        private string nome;
        private string indirizzo;
        private List<Dipendente> dipendenti;
        private List<Ordine> ordini;
        private List<Cliente> clienti;

        public Ristorante()
        {
        }

        public Ristorante(string nome, string indirizzo)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.dipendenti = new List<Dipendente>();
            this.ordini = new List<Ordine>();
            this.clienti = new List<Cliente>();
        }

        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public List<Dipendente> Dipendenti { get => dipendenti; set => dipendenti = value; }
        public List<Ordine> Ordini { get => ordini; set { ordini = value; foreach (Ordine o in ordini) o.Ristorante = this; } }
        public List<Cliente> Clienti { get => clienti; set { clienti = value; foreach (Cliente c in clienti) c.Ristorante = this; } }

        static public BindingList<Ristorante> GetData()
        {
            return new BindingList<Ristorante>()
                   {
                       new Ristorante("McCadel", "Via Roma")
                   };
        }
    }
}