using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Cliente
    {
        private string nome;
        private string cognome;
        private Ordine ordine;
        private Ristorante ristorante;

        public Cliente(string nome, string cognome, Ristorante ristorante)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.ristorante = ristorante;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public Ordine Ordine { get => ordine; set => ordine = value; }
        public Ristorante Ristorante { get => ristorante; set => ristorante = value; }

        public void ordina(int ntavolo, List<Prodotto> prodotti)
        {
            ristorante.Ordini.Add(this.ordine = new Ordine(ntavolo, prodotti, this.ristorante, this));
        }
    }
}
