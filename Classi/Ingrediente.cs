using System.ComponentModel;

namespace Classi
{
    public class Ingrediente(string nome, int quantita)
    {
        static private List<Ingrediente>? ingredienti;
        public string Nome => nome;
        public int Quantita { get; set; } = quantita;
        static private List<Ingrediente> GetSampleData()
        {
            return new List<Ingrediente>()
                {

                    new Ingrediente("Coca cola", 10),
                    new Ingrediente("Fanta", 10),
                    new Ingrediente("Carne", 10),
                    new Ingrediente("Insalata", 10),
                    new Ingrediente("Pomodoro", 10),
                    new Ingrediente("Maionese", 30),
                    new Ingrediente("Formaggio", 10),
                    new Ingrediente("Patatine", 10),
                    new Ingrediente("Nuggets", 10)
                };
        }
        static public List<Ingrediente> GetData()
        {
            if (ingredienti == null)
            {
                ingredienti = GetSampleData();
            }
            return ingredienti;
        }

    }
}
