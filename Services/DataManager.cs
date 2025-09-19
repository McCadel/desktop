/*
Qui gestisco le gli attributi delle classi in modo specifico a differenza di JsonService,
che invece è più generico e riutilizzabile.

Dedicato a:

_________             .___     .__    ___________                            
\_   ___ \_____     __| _/____ |  |   \_   _____/__  _______    ____   ______
/    \  \/\__  \   / __ |/ __ \|  |    |    __)_\  \/ /\__  \  /    \ /  ___/
\     \____/ __ \_/ /_/ \  ___/|  |__  |        \\   /  / __ \|   |  \\___ \ 
 \______  (____  /\____ |\___  >____/ /_______  / \_/  (____  /___|  /____  >
        \/     \/      \/    \/               \/            \/     \/     \/ 

             Il ciclista più dopato del mondo.

COME UTILIZZARE:

    Ci sono 2 modi, si può creare un istanza diretta -> var dataManager = new DataManager(); e poi usare i metodi -> await dataManager.SalvaRistoranteCompletoAsync(nuovoRistorante);
    Oppure si può passare DataManager come parametro di una classe. NON CONSIGLIATO
*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Classi.Services
{
    public class DataManager
    {
        private readonly JsonService _jsonService;

        private const string RISTORANTE_FILE = "ristorante.json";
        private const string BACKUP_FILE = "backup_completo.json";

        public DataManager()
        {
            _jsonService = new JsonService();
        }

        // Lil backup delle classi, senza questo si creerebbe un loop infinito (not good)
        public class RistoranteBackup
        {
            public string Nome { get; set; } = string.Empty;
            public string Indirizzo { get; set; } = string.Empty;
            public List<DipendenteDati> Dipendenti { get; set; } = new();
            public List<ClienteDati> Clienti { get; set; } = new();
            public List<OrdineDati> Ordini { get; set; } = new();
            public MagazzinoDati? Magazzino { get; set; }
        }

        public class DipendenteDati
        {
            public string Nome { get; set; } = string.Empty;
            public string Cognome { get; set; } = string.Empty;
            public double Stipendio { get; set; }
        }

        public class ClienteDati
        {
            public string Nome { get; set; } = string.Empty;
            public string Cognome { get; set; } = string.Empty;
            public OrdineDati? Ordine { get; set; }
        }

        public class OrdineDati
        {
            public int NumeroTavolo { get; set; }
            public List<ProdottoDati> Prodotti { get; set; } = new();
            public string NomeCliente { get; set; } = string.Empty;
            public string CognomeCliente { get; set; } = string.Empty;
            public double PrezzoTotale { get; set; }
        }

        public class ProdottoDati
        {
            public string Nome { get; set; } = string.Empty;
            public double Prezzo { get; set; }
            public List<IngredienteDati> Ingredienti { get; set; } = new();
            public List<string> MenuAssociati { get; set; } = new();
        }

        public class IngredienteDati
        {
            public string Nome { get; set; } = string.Empty;
            public int Quantita { get; set; }
        }

        public class MenuDati
        {
            public string Nome { get; set; } = string.Empty;
            public List<string> NomiProdotti { get; set; } = new();
        }

        public class MagazzinoDati
        {
            public List<ProdottoDati> Prodotti { get; set; } = new();
            public List<IngredienteDati> Ingredienti { get; set; } = new();
        }

        // Metodo principale per salvare tutto il ristorante
        public async Task SalvaRistoranteCompletoAsync(Ristorante ristorante)
        {
            try
            {
                var backup = new RistoranteBackup
                {
                    Nome = ristorante.Nome,
                    Indirizzo = ristorante.Indirizzo
                };

                // Dipendentii
                backup.Dipendenti = ristorante.Dipendenti.Select(d => new DipendenteDati
                {
                    Nome = d.Nome,
                    Cognome = d.Cognome,
                    Stipendio = d.Stipendio
                }).ToList();

                // Clienti
                backup.Clienti = ristorante.Clienti.Select(c => new ClienteDati
                {
                    Nome = c.Nome,
                    Cognome = c.Cognome,
                    Ordine = c.Ordine != null ? new OrdineDati
                    {
                        NumeroTavolo = c.Ordine.NumeroTavolo,
                        NomeCliente = c.Ordine.Cliente.Nome,
                        CognomeCliente = c.Ordine.Cliente.Cognome,
                        PrezzoTotale = c.Ordine.CalcolaPrezzo(),
                        Prodotti = EstraiProdottiDaOrdine(c.Ordine)
                    } : null
                }).ToList();

                // Ordini
                backup.Ordini = ristorante.Ordini.Select(o => new OrdineDati
                {
                    NumeroTavolo = o.NumeroTavolo,
                    NomeCliente = o.Cliente.Nome,
                    CognomeCliente = o.Cliente.Cognome,
                    PrezzoTotale = o.CalcolaPrezzo(),
                    Prodotti = EstraiProdottiDaOrdine(o)
                }).ToList();

                await _jsonService.SaveSingleAsync(backup, BACKUP_FILE);
                Console.WriteLine($"Ristorante '{ristorante.Nome}' salvato con successo!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio del ristorante: {ex.Message}");
            }
        }

        // Qui Carico il ristorante (completo)
        public async Task<Ristorante?> CaricaRistoranteCompletoAsync()
        {
            try
            {
                var backup = await _jsonService.LoadSingleAsync<RistoranteBackup>(BACKUP_FILE);
                
                if (string.IsNullOrEmpty(backup.Nome))
                {
                    return null;
                }

                // Ricostruisce il ristorante
                var ristorante = new Ristorante(backup.Nome, backup.Indirizzo);

                // Ricostruisce i dipendenti
                foreach (var dipDati in backup.Dipendenti)
                {
                    var dipendente = new Dipendente(ristorante, dipDati.Nome, dipDati.Cognome, dipDati.Stipendio);
                    ristorante.Dipendenti.Add(dipendente);
                }

                // Ricostruisce i clienti (senza ordini per ora)
                foreach (var clienteDati in backup.Clienti)
                {
                    var cliente = new Cliente(clienteDati.Nome, clienteDati.Cognome, ristorante);
                    ristorante.Clienti.Add(cliente);
                }

                Console.WriteLine($"Ristorante '{ristorante.Nome}' caricato con successo!");
                Console.WriteLine($"- Dipendenti: {ristorante.Dipendenti.Count}");
                Console.WriteLine($"- Clienti: {ristorante.Clienti.Count}");
                Console.WriteLine($"- Ordini nel backup: {backup.Ordini.Count}");

                return ristorante;
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento del ristorante: {ex.Message}");
            }
        }

        // Salva i singoli elementi 
        public async Task SalvaDipendentiAsync(List<Dipendente> dipendenti)
        {
            var datiDipendenti = dipendenti.Select(d => new DipendenteDati
            {
                Nome = d.Nome,
                Cognome = d.Cognome,
                Stipendio = d.Stipendio
            }).ToList();

            await _jsonService.SaveDataAsync(datiDipendenti, "dipendenti.json");
        }

        public async Task SalvaClientiAsync(List<Cliente> clienti)
        {
            var datiClienti = clienti.Select(c => new ClienteDati
            {
                Nome = c.Nome,
                Cognome = c.Cognome,
                Ordine = c.Ordine != null ? new OrdineDati
                {
                    NumeroTavolo = c.Ordine.NumeroTavolo,
                    NomeCliente = c.Nome,
                    CognomeCliente = c.Cognome,
                    PrezzoTotale = c.Ordine.CalcolaPrezzo()
                } : null
            }).ToList();

            await _jsonService.SaveDataAsync(datiClienti, "clienti.json");
        }

        public async Task SalvaOrdiniAsync(List<Ordine> ordini)
        {
            var datiOrdini = ordini.Select(o => new OrdineDati
            {
                NumeroTavolo = o.NumeroTavolo,
                NomeCliente = o.Cliente.Nome,
                CognomeCliente = o.Cliente.Cognome,
                PrezzoTotale = o.CalcolaPrezzo()
            }).ToList();

            await _jsonService.SaveDataAsync(datiOrdini, "ordini.json");
        }

        // Teoricamente dovrebbe estrarre i prodotti
        private List<ProdottoDati> EstraiProdottiDaOrdine(Ordine ordine)
        {
            // Non implementato perché i prodotti sono privati :/
            return new List<ProdottoDati>();
        }

        // Verifica
        public async Task<bool> EsistonoDatiSalvatiAsync()
        {
            try
            {
                var backup = await _jsonService.LoadSingleAsync<RistoranteBackup>(BACKUP_FILE);
                return !string.IsNullOrEmpty(backup.Nome);
            }
            catch
            {
                return false;
            }
        }

        // Eliminare dati salvati
        public async Task EliminaDatiAsync()
        {
            try
            {
                string backupPath = Path.Combine("Data", BACKUP_FILE);
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                Console.WriteLine("Dati eliminati con successo!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante l'eliminazione dei dati: {ex.Message}");
            }
        }
    }
}
