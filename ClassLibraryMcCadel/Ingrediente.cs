using System.Text.Json;

namespace ClassLibraryMcCadel
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
                if (!LoadDataFromJson())
                    ingredienti = GetSampleData();
            }
            return ingredienti;
        }

        private static readonly string pathToFile = "..\\..\\..\\ingredienti.json";
        public static bool SaveDataToJson()
        {
            string json = JsonSerializer.Serialize(ingredienti, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathToFile, json);
            return true;
        }

        public static bool LoadDataFromJson()
        {
            if (File.Exists(pathToFile))
            {
                string json = File.ReadAllText(pathToFile);
                ingredienti = JsonSerializer.Deserialize<List<Ingrediente>>(json);
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return nome + ": " + quantita;
        }

    }
}
