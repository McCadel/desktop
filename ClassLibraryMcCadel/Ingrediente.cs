using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Ingrediente
    {
        private string nome;
        private int quantita;
        private Prodotto prodotto;

        public Ingrediente()
        {
        }

        public Ingrediente(string nome, int quantita, Prodotto prodotto)
        {
            this.nome = nome;
            this.quantita = quantita;
            this.prodotto = prodotto;
            this.prodotto.addingrediente(this);
        }
        public string Nome { get => nome; set => nome = value; }
        public int Quantita { get => quantita; set => quantita = value; }
        public Prodotto Prodotto { get => prodotto; set { prodotto = value; prodotto.addingrediente(this); } }
    }
}
