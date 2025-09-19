namespace Classi{
    public class Dipendente(Ristorante ristorante, string nome, string cognome, double stipendio)
    {
        public Ristorante Ristorante { get; set; } = ristorante;
        public string Nome { get; set; } = nome;
        public string Cognome { get; set; } = cognome;
        public double Stipendio { get; set; } = stipendio;
    }
}
