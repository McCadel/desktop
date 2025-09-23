using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Ordine
    {
        private int numeroTavolo;
        private List<Prodotto> prodotti;
        private Ristorante ristorante;
        private Cliente cliente;

        public Ordine()
        {
        }

        public Ordine(int numeroTavolo, List<Prodotto> prodotti, Ristorante ristorante, Cliente cliente)
        {
            this.numeroTavolo = numeroTavolo;
            this.prodotti = prodotti;
            this.ristorante = ristorante;
            this.cliente = cliente;
        }
        public int NumeroTavolo { get => numeroTavolo; set => numeroTavolo = value; }
        public Ristorante Ristorante { get => ristorante; set { ristorante = value; } }
        public Cliente Cliente { get => cliente; set { cliente = value;  } }

        public List<Prodotto> Prodotti { get => prodotti; set => prodotti = value; }

        public double calcolaPrezzo()
        {
            double prezzo = 0;
            foreach(Prodotto p in prodotti){
                prezzo += p.Prezzo;
            }
            return prezzo;
        }
    }
}
