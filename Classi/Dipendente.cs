using System.ComponentModel;

namespace Classi{
    public class Dipendente(Ristorante ristorante, string nome, string cognome, double stipendio)
    {
        static private BindingList<Dipendente>? dipendenti;
        public Ristorante Ristorante { get; set; } = ristorante;
        public string Nome { get; set; } = nome;
        public string Cognome { get; set; } = cognome;
        public double Stipendio { get; set; } = stipendio;

        static private BindingList<Dipendente> GetSampleData()
        {
            return new BindingList<Dipendente>()
            {
                new Dipendente(Ristorante.GetData()[0], "Marco", "Pantani", 1400),
                new Dipendente(Ristorante.GetData()[0], "Vincenzo", "Nibali", 1400)
            };
        }
        static public BindingList<Dipendente> GetData()
        {
            if (dipendenti == null)
            {
                dipendenti = GetSampleData();
            }
            return dipendenti;
        }
    }
}
