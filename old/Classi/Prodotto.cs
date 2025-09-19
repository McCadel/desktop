namespace Classi
{
    public class Prodotto(string nome, double prezzo, Magazzino magazzino, List<Menu> menu, List<Ingrediente> ingredienti)
    {
        public string Nome { get; set; } = nome;
        public double Prezzo { get; set; } = prezzo;
        public Magazzino Magazzino { get; set; } = magazzino;
        public List<Menu> Menu { get; set; } = menu;
        public List<Ingrediente> Ingredienti { get; set; } = ingredienti;
    }
}
