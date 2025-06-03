using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Prodotto
    {
        private string nome;
        private double prezzo;
        private Ordine ordine;
        private Magazzino magazzino;
        private List<Menu> menu;
        private List<Ingrediente> ingredienti;
        public Prodotto(string nome, double prezzo, Magazzino magazzino, List<Menu> menu, List<Ingrediente> ingredienti)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.magazzino = magazzino;
            this.menu = menu;
            this.ingredienti = ingredienti;
        }
        public string Nome { get => nome; set => nome = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public Magazzino Magazzino { get => magazzino; set => magazzino = value; }
        public List<Menu> Menu { get => menu; set => menu = value; }
        public List<Ingrediente> Ingredienti { get => ingredienti; set => ingredienti = value; }
    }
}
