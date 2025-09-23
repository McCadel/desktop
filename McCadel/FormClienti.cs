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
    public partial class FormClienti : Form
    {
        private Cliente cliente;
        public FormClienti()
        {
            InitializeComponent();
        }
        public FormClienti(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            tnome.Text = cliente.Nome;
            tcognome.Text = cliente.Cognome;
        }

        private void binserisci_Click(object sender, EventArgs e)
        {
            lerrore.Text = "";
            if (string.IsNullOrWhiteSpace(tnome.Text) || string.IsNullOrWhiteSpace(tcognome.Text))
            {
                lerrore.Text = "Errore, completare tutti i campi";
                return; // Esce dalla funzione, non fa nient'altro
            }

            string nuovoNome = tnome.Text;
            string nuovoCognome = tcognome.Text;
            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            List<Cliente> clienti;
            if (File.Exists("Clienti.json"))
            {
                clienti = JsonSerializer.Deserialize<List<Cliente>>(File.ReadAllText("Clienti.json"), jsonOptions);
            }
            else
            {
                clienti = new List<Cliente>();
            }

            if (this.cliente != null)
            {
                bool duplicatoTrovato = false;
                string clienteOriginaleJson = JsonSerializer.Serialize<Cliente>(this.cliente, jsonOptions);

                foreach (Cliente c in clienti)
                {
                    string clienteCorrenteJson = JsonSerializer.Serialize<Cliente>(c, jsonOptions);
                    if (clienteCorrenteJson.Equals(clienteOriginaleJson))
                    {
                        continue;
                    }
                    if (c.Nome.Equals(nuovoNome) && c.Cognome.Equals(nuovoCognome))
                    {
                        duplicatoTrovato = true;
                        break;
                    }
                }

                if (duplicatoTrovato)
                {
                    lerrore.Text = "Cliente già registrato con questo nome e cognome";
                    return;
                }
                Cliente clienteDaAggiornare = null;
                foreach (Cliente c in clienti)
                {
                    if (JsonSerializer.Serialize<Cliente>(c, jsonOptions).Equals(clienteOriginaleJson))
                    {
                        clienteDaAggiornare = c;
                        break;
                    }
                }

                if (clienteDaAggiornare != null)
                {
                    clienteDaAggiornare.Nome = nuovoNome;
                    clienteDaAggiornare.Cognome = nuovoCognome;
                }
                else
                {
                    lerrore.Text = "Errore: cliente da modificare non trovato.";
                    return;
                }
            }
            else
            {
                bool duplicatoTrovato = false;
                foreach (Cliente c in clienti)
                {
                    if (c.Nome.Equals(nuovoNome) && c.Cognome.Equals(nuovoCognome))
                    {
                        duplicatoTrovato = true;
                        break;
                    }
                }

                if (duplicatoTrovato)
                {
                    lerrore.Text = "Cliente già registrato";
                    return; // Esce
                }
                Cliente nuovoCliente = new Cliente(nuovoNome, nuovoCognome);
                clienti.Add(nuovoCliente);
            }
            File.WriteAllText("Clienti.json", JsonSerializer.Serialize<List<Cliente>>(clienti, jsonOptions));
            this.Close();
        }
    }
}
