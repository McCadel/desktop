using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Cliente
    {
        private string nome;
        private string cognome;
        private Ristorante ristorante;
        private List<Ordine> ordini = new List<Ordine>();
        public Cliente() { }
        public Cliente(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.Ordini = new List<Ordine>();
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public Ristorante Ristorante { get => ristorante; set => ristorante = value; }
        public List<Ordine> Ordini { get => ordini; set => ordini = value; }

        public override string ToString()
        {
            return $"{nome} {cognome}";
        }

    }
}