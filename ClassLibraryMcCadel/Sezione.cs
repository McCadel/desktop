using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Sezione
    {
        private string nome;
        private BindingList<Prodotto> prodotti=new BindingList<Prodotto>();

        public Sezione()
        {
        }

        public Sezione(string nome, BindingList<Prodotto> prodotti)
        {
            this.nome = nome;
            this.prodotti = prodotti;
        }

        public Sezione(string nome)
        {
            this.nome = nome;
        }

        public void Addprodotto(Prodotto p)
        {
            prodotti.Add(p);
        }
        public string Nome { get => nome; set => nome = value; }
        public BindingList<Prodotto> Prodotti { get => prodotti; set => prodotti = value; }
    }
}
