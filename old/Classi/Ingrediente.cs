namespace Classi
{
    public class Ingrediente(string nome, int quantita)
    {
        public string Nome => nome;
        public int Quantita { get; set; } = quantita;
    }
}
