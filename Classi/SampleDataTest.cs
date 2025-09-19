/*
 * Programma di test per verificare il caricamento dei dati di esempio
 */

using System;
using System.Threading.Tasks;
using Classi;
using Classi.Services;

namespace Classi.Test
{
    public class SampleDataTest
    {
        public static async Task TestSampleDataLoading()
        {
            try
            {
                Console.WriteLine("=== Test Caricamento Dati di Esempio ===");
                
                // Crea un ristorante di test
                var ristorante = new Ristorante("McCadel Test", "Via Roma 123, Milano");
                
                // Crea il loader dei dati di esempio
                var sampleLoader = new SampleDataLoader();
                
                // Verifica se esistono i file di esempio
                if (sampleLoader.EsistonoDatiEsempio())
                {
                    Console.WriteLine("✓ File di dati di esempio trovati");
                    
                    // Carica i dati di esempio
                    await sampleLoader.CaricaDatiEsempioAsync(ristorante);
                    
                    // Mostra i risultati
                    Console.WriteLine("\n=== Risultati Caricamento ===");
                    Console.WriteLine($"Ristorante: {ristorante.Nome}");
                    Console.WriteLine($"Indirizzo: {ristorante.Indirizzo}");
                    Console.WriteLine($"Numero dipendenti: {ristorante.Dipendenti.Count}");
                    Console.WriteLine($"Numero clienti: {ristorante.Clienti.Count}");
                    
                    // Mostra dettagli dipendenti
                    Console.WriteLine("\n=== Dipendenti Caricati ===");
                    foreach (var dipendente in ristorante.Dipendenti)
                    {
                        Console.WriteLine($"- {dipendente.Nome} {dipendente.Cognome} (Stipendio: €{dipendente.Stipendio})");
                    }
                    
                    // Mostra dettagli clienti
                    Console.WriteLine("\n=== Clienti Caricati ===");
                    foreach (var cliente in ristorante.Clienti)
                    {
                        Console.WriteLine($"- {cliente.Nome} {cliente.Cognome}");
                    }
                    
                    Console.WriteLine("\n✓ Test completato con successo!");
                }
                else
                {
                    Console.WriteLine("✗ File di dati di esempio non trovati");
                    Console.WriteLine("Assicurarsi che esistano i file:");
                    Console.WriteLine("- Data/dipendenti.json");
                    Console.WriteLine("- Data/clienti.json");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Errore durante il test: {ex.Message}");
            }
        }

        public static async Task TestDataManagerWithSampleData()
        {
            try
            {
                Console.WriteLine("\n=== Test DataManager con Dati di Esempio ===");
                
                // Crea un ristorante e carica i dati di esempio
                var ristorante = new Ristorante("McCadel DataManager Test", "Via Milano 456, Roma");
                var sampleLoader = new SampleDataLoader();
                
                await sampleLoader.CaricaDatiEsempioAsync(ristorante);
                
                // Usa DataManager per salvare tutto
                var dataManager = new DataManager();
                await dataManager.SalvaRistoranteCompletoAsync(ristorante);
                
                // Ricarica dal backup
                var ristoranteCaricato = await dataManager.CaricaRistoranteCompletoAsync();
                
                if (ristoranteCaricato != null)
                {
                    Console.WriteLine("✓ Salvataggio e caricamento tramite DataManager riuscito");
                    Console.WriteLine($"Ristorante caricato: {ristoranteCaricato.Nome}");
                    Console.WriteLine($"Dipendenti: {ristoranteCaricato.Dipendenti.Count}");
                    Console.WriteLine($"Clienti: {ristoranteCaricato.Clienti.Count}");
                }
                else
                {
                    Console.WriteLine("✗ Errore nel caricamento tramite DataManager");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Errore durante il test DataManager: {ex.Message}");
            }
        }
    }
}