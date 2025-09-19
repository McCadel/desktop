using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Menu
    {
        private string nome;
        private List<Prodotto> prodotti;

        public Menu(string nome, List<Prodotto> prodotto)
        {
            this.nome = nome;
            this.prodotti = prodotto;
        }
        public string Nome { get => nome; set => nome = value; }
        public List<Prodotto> Prodotti { get => prodotti; set => prodotti = value; }
    }
}
