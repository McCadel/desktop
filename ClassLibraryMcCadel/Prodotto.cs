using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMcCadel
{
    public class Prodotto
    {
        private string nome;
        private string descrizione;
        private double prezzo;
        private List<Ingrediente> ingredienti = new List<Ingrediente>();

        public Prodotto()
        {
        }

        public Prodotto(string nome, string descrizione, double prezzo)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }

        public Prodotto(string nome, double prezzo, List<Ingrediente> ingredienti, string descrizione)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.ingredienti = ingredienti;
            this.descrizione = descrizione;
        }
        public void addingrediente(Ingrediente i)
        {
            ingredienti.Add(i);
        }
        public void remingrediente(Ingrediente i)
        {
            ingredienti.Remove(i);
        }
        public string Nome { get => nome; set => nome = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public List<Ingrediente> Ingredienti { get => ingredienti; set => ingredienti = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
    }
}