/*
 * Classe per gestire l'inizializzazione dei dati di esempio per clienti e dipendenti
 * 
 * COME UTILIZZARE:
 * var sampleDataLoader = new SampleDataLoader();
 * await sampleDataLoader.CaricaDatiEsempioAsync(ristorante);
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Classi.Services;

namespace Classi.Services
{
    public class SampleDataLoader
    {
        private readonly DataManager _dataManager;
        private readonly JsonService _jsonService;

        public SampleDataLoader()
        {
            _dataManager = new DataManager();
            _jsonService = new JsonService();
        }

        /// <summary>
        /// Carica i dati di esempio per dipendenti e clienti nel ristorante fornito
        /// </summary>
        /// <param name="ristorante">Il ristorante in cui caricare i dati</param>
        public async Task CaricaDatiEsempioAsync(Ristorante ristorante)
        {
            try
            {
                await CaricaDipendentiEsempioAsync(ristorante);
                await CaricaClientiEsempioAsync(ristorante);
                
                Console.WriteLine("Dati di esempio caricati con successo!");
                Console.WriteLine($"- Dipendenti caricati: {ristorante.Dipendenti.Count}");
                Console.WriteLine($"- Clienti caricati: {ristorante.Clienti.Count}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento dei dati di esempio: {ex.Message}");
            }
        }

        /// <summary>
        /// Carica solo i dipendenti di esempio
        /// </summary>
        /// <param name="ristorante">Il ristorante in cui aggiungere i dipendenti</param>
        public async Task CaricaDipendentiEsempioAsync(Ristorante ristorante)
        {
            try
            {
                var dipendentiDati = await _jsonService.LoadDataAsync<DataManager.DipendenteDati>("dipendenti.json");
                
                foreach (var dipDati in dipendentiDati)
                {
                    var dipendente = new Dipendente(ristorante, dipDati.Nome, dipDati.Cognome, dipDati.Stipendio);
                    ristorante.Dipendenti.Add(dipendente);
                }
                
                Console.WriteLine($"Caricati {dipendentiDati.Count} dipendenti di esempio");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento dei dipendenti di esempio: {ex.Message}");
            }
        }

        /// <summary>
        /// Carica solo i clienti di esempio
        /// </summary>
        /// <param name="ristorante">Il ristorante in cui aggiungere i clienti</param>
        public async Task CaricaClientiEsempioAsync(Ristorante ristorante)
        {
            try
            {
                var clientiDati = await _jsonService.LoadDataAsync<DataManager.ClienteDati>("clienti.json");
                
                foreach (var clienteDati in clientiDati)
                {
                    var cliente = new Cliente(clienteDati.Nome, clienteDati.Cognome, ristorante);
                    
                    // Se il cliente ha un ordine nei dati di esempio, lo aggiungiamo per completezza
                    // Nota: in questo caso semplificato non ricostruiamo l'ordine completo
                    // perché mancano i riferimenti ai prodotti
                    
                    ristorante.Clienti.Add(cliente);
                }
                
                Console.WriteLine($"Caricati {clientiDati.Count} clienti di esempio");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento dei clienti di esempio: {ex.Message}");
            }
        }

        /// <summary>
        /// Verifica se esistono i file di dati di esempio
        /// </summary>
        /// <returns>True se esistono entrambi i file di esempio</returns>
        public bool EsistonoDatiEsempio()
        {
            try
            {
                string dataDirectory = "Data";
                string dipendentiPath = Path.Combine(dataDirectory, "dipendenti.json");
                string clientiPath = Path.Combine(dataDirectory, "clienti.json");
                
                return File.Exists(dipendentiPath) && File.Exists(clientiPath);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Salva i dati correnti del ristorante come dati di esempio
        /// </summary>
        /// <param name="ristorante">Il ristorante di cui salvare i dati</param>
        public async Task SalvaDatiComeEsempioAsync(Ristorante ristorante)
        {
            try
            {
                await _dataManager.SalvaDipendentiAsync(ristorante.Dipendenti);
                await _dataManager.SalvaClientiAsync(ristorante.Clienti);
                
                Console.WriteLine("Dati salvati come esempio!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio dei dati come esempio: {ex.Message}");
            }
        }
    }
}