using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCadel
{
    public partial class FormRistorante : Form
    {
        Ristorante r;
        public FormRistorante()
        {
            InitializeComponent();
        }
        public FormRistorante(Ristorante r)
        {
            InitializeComponent();
            this.r = r;
            tnome.Text = r.Nome;
            tindirizzo.Text = r.Indirizzo;
        }

        private void bfine_Click(object sender, EventArgs e)
        {
            lerrore.Text = "";
            string nuovoNome = tnome.Text;
            string nuovoIndirizzo = tindirizzo.Text;
            if (string.IsNullOrWhiteSpace(nuovoNome) || string.IsNullOrWhiteSpace(nuovoIndirizzo))
            {
                lerrore.Text = "Errore, completare tutti i campi";
                return;
            }
            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            List<Ristorante> ristoranti;
            if (File.Exists("Ristoranti.json"))
            {
                ristoranti = JsonSerializer.Deserialize<List<Ristorante>>(File.ReadAllText("Ristoranti.json"), jsonOptions);
            }
            else
            {
                ristoranti = new List<Ristorante>();
            }
            try
            {
                if (this.r != null)
                {
                    string ristoranteOriginaleJson = JsonSerializer.Serialize<Ristorante>(this.r, jsonOptions);
                    Ristorante ristoranteDaAggiornare = ristoranti.FirstOrDefault(ri =>
                    JsonSerializer.Serialize<Ristorante>(ri, jsonOptions).Equals(ristoranteOriginaleJson));

                    if (ristoranteDaAggiornare == null)
                    {
                        lerrore.Text = "Errore: ristorante da modificare non trovato.";
                        return;
                    }
                    bool duplicatoEsistente = ristoranti.Any(ri =>
                        ri.Nome.Equals(nuovoNome) &&
                        ri.Indirizzo.Equals(nuovoIndirizzo) &&
                        ri != ristoranteDaAggiornare);
                    if (duplicatoEsistente)
                    {
                        lerrore.Text = "Un altro ristorante esiste già con questo nome e indirizzo";
                        return;
                    }
                    ristoranteDaAggiornare.Nome = nuovoNome;
                    ristoranteDaAggiornare.Indirizzo = nuovoIndirizzo;
                }
                else
                {
                    bool duplicatoEsistente = ristoranti.Any(ri =>
                        ri.Nome.Equals(nuovoNome) &&
                        ri.Indirizzo.Equals(nuovoIndirizzo));

                    if (duplicatoEsistente)
                    {
                        lerrore.Text = "Ristorante già registrato";
                        return;
                    }
                    ristoranti.Add(new Ristorante(nuovoNome, nuovoIndirizzo));
                }
                File.WriteAllText("Ristoranti.json", JsonSerializer.Serialize<List<Ristorante>>(ristoranti, jsonOptions));
                this.Close();
            }
            catch (Exception ex)
            {
                lerrore.Text = $"Errore: {ex.Message}";
            }
        }
    }
}
