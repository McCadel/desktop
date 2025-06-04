namespace Classi
{
    public class Menu(string nome, List<Prodotto> prodotto)
    {
        
        public string Nome { get; set; } = nome;
        public List<Prodotto> Prodotti { get; set; } = prodotto;
    }
}
