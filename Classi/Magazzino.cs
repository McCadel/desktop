using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Magazzino
    {
        private Ristorante ristorante;
        private List<Prodotto> prodotti;

        public Magazzino(List<Prodotto> prodotti, Ristorante ristorante)
        {
            this.prodotti = prodotti;
            this.ristorante = ristorante;
        }
        public Magazzino(Ristorante ristorante)
        {
            this.prodotti = [];
            this.ristorante = ristorante;
        }

        public List<Prodotto> Prodotti { get => prodotti; set => prodotti = value; }
        public Ristorante Ristorante { get => ristorante; set => ristorante = value; }
    }
}
