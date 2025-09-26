using System.ComponentModel;

namespace ClassLibraryMcCadel
{
    public class Menu(string nome, List<Prodotto> prodotto)
    {
        static private List<Menu>? menus;
        public string Nome { get; set; } = nome;
        public List<Prodotto> Prodotti { get; set; } = prodotto;

        static private List<Menu> GetSampleData()
        {
            return new List<Menu>()
                {
                    new Menu("CadelMenu", [])
                };
        }
        static public List<Menu> GetData()
        {
            if (menus == null)
            {
                menus = GetSampleData();
                Prodotto.GetData();
            }
            return menus;
        }

    }
}
