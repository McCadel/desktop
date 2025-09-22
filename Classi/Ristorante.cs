using System.ComponentModel;

namespace Classi
{
    public class Ristorante(string nome, string indirizzo)
    {
        static private BindingList<Ristorante>? ristoranti;
        public string Nome { get; set; } = nome;
        public string Indirizzo { get; set; } = indirizzo;
        public List<Dipendente> Dipendenti { get; set; } = [];
        public List<Ordine> Ordini { get; set; } = [];
        public List<Cliente> Clienti { get; set; } = [];
        static private BindingList<Ristorante> GetSampleData()
        {
            return new BindingList<Ristorante>()
                   {
                       new Ristorante("McCadel", "Via Roma")
                   };
        }
        static public BindingList<Ristorante> GetData()
        {
            if (ristoranti == null)
            {
                ristoranti=GetSampleData();

            }
            return ristoranti;
        }
    }
}
