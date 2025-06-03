using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Dipendente
    {
        private Ristorante ristorante;
        private string nome;
        private string cognome;
        private double stipendio;

        public Dipendente(Ristorante ristorante, string nome, string cognome, double stipendio)
        {
            this.ristorante = ristorante;
            this.nome = nome;
            this.cognome = cognome;
            this.stipendio = stipendio;
        }

        public Ristorante Ristorante { get => ristorante; set => ristorante = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public double Stipendio { get => stipendio; set => stipendio = value; }
    }
}
