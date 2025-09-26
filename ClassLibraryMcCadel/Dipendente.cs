namespace ClassLibraryMcCadel
{
    public class Dipendente
    {
        private Ristorante ristorante;
        private string nome;
        private string cognome;
        private double stipendio;

        static private List<Dipendente>? dipendenti;

        public Dipendente()
        {

        }
        public Dipendente(Ristorante ristorante, string nome, string cognome, double stipendio)
        {
            this.ristorante = ristorante;
            this.nome = nome;
            this.cognome = cognome;
            this.stipendio = stipendio;
        }

        public Dipendente(string nome, string cognome, double stipendio)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.stipendio = stipendio;
        }

        public Ristorante Ristorante { get => ristorante; set => ristorante = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public double Stipendio { get => stipendio; set => stipendio = value; }

        // --- Metodi richiesti ---
        static private List<Dipendente> GetSampleData()
        {
            var ristorante = Ristorante.GetData()[0]; // Usa il ristorante McCadel già creato

            return new List<Dipendente>()
            {
                new Dipendente( "Mario", "Rossi", 1500),
                new Dipendente( "Luca", "Bianchi", 1400),
                new Dipendente( "Giulia", "Verdi", 1600),
                new Dipendente( "Anna", "Neri", 1550)
            };
        }

        static public List<Dipendente> GetData()
        {
            if (dipendenti == null)
            {
                dipendenti = GetSampleData();
            }
            return dipendenti;
        }
    }
}
