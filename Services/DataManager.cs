/*
DataManager per gestire il salvataggio specifico delle classi McCadel
Utilizza JsonService per le operazioni di I/O

UTILIZZO:
var dataManager = new DataManager(); -> Costruttore
await dataManager.SalvaRistorantiAsync(listaRistoranti); -> Scrvi su file
var ristoranti = await dataManager.CaricaRistorantiAsync(); -> Leggi da file
*/

using ClassLibraryMcCadel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Classi.Services
{
    public class DataManager
    {
        private readonly JsonService _jsonService;

        // Vari json
        private const string RISTORANTI_FILE = "ristoranti.json";
        private const string CLIENTI_FILE = "clienti.json";
        private const string ORDINI_FILE = "ordini.json";
        private const string DIPENDENTI_FILE = "dipendenti.json";
        private const string PRODOTTI_FILE = "prodotti.json";
        private const string INGREDIENTI_FILE = "ingredienti.json";

        public DataManager()
        {
            _jsonService = new JsonService();
        }

        #region Ristoranti
        public async Task SalvaRistorantiAsync(List<Ristorante> ristoranti)
        {
            try
            {
                await _jsonService.SaveDataAsync(ristoranti, RISTORANTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio dei ristoranti: {ex.Message}");
            }
        }

        public async Task<List<Ristorante>> CaricaRistorantiAsync()
        {
            try
            {
                return await _jsonService.LoadDataAsync<Ristorante>(RISTORANTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel caricamento dei ristoranti: {ex.Message}");
            }
        }

        public async Task SalvaRistoranteAsync(Ristorante ristorante)
        {
            try
            {
                var ristoranti = await CaricaRistorantiAsync();
                var esistente = ristoranti.FirstOrDefault(r => r.Nome == ristorante.Nome && r.Indirizzo == ristorante.Indirizzo);
                
                if (esistente != null)
                {
                    var index = ristoranti.IndexOf(esistente);
                    ristoranti[index] = ristorante;
                }
                else
                {
                    ristoranti.Add(ristorante);
                }
                
                await SalvaRistorantiAsync(ristoranti);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio del ristorante: {ex.Message}");
            }
        }

        public async Task EliminaRistoranteAsync(Ristorante ristorante)
        {
            try
            {
                var ristoranti = await CaricaRistorantiAsync();
                ristoranti.Remove(ristorante);
                await SalvaRistorantiAsync(ristoranti);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nell'eliminazione del ristorante: {ex.Message}");
            }
        }
        #endregion

        #region Clienti
        public async Task SalvaClientiAsync(List<Cliente> clienti)
        {
            try
            {
                await _jsonService.SaveDataAsync(clienti, CLIENTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio dei clienti: {ex.Message}");
            }
        }

        public async Task<List<Cliente>> CaricaClientiAsync()
        {
            try
            {
                return await _jsonService.LoadDataAsync<Cliente>(CLIENTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel caricamento dei clienti: {ex.Message}");
            }
        }

        public async Task SalvaClienteAsync(Cliente cliente)
        {
            try
            {
                var clienti = await CaricaClientiAsync();
                var esistente = clienti.FirstOrDefault(c => c.Nome == cliente.Nome && c.Cognome == cliente.Cognome);
                
                if (esistente != null)
                {
                    var index = clienti.IndexOf(esistente);
                    clienti[index] = cliente;
                }
                else
                {
                    clienti.Add(cliente);
                }
                
                await SalvaClientiAsync(clienti);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio del cliente: {ex.Message}");
            }
        }

        public async Task EliminaClienteAsync(Cliente cliente)
        {
            try
            {
                var clienti = await CaricaClientiAsync();
                clienti.Remove(cliente);
                await SalvaClientiAsync(clienti);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nell'eliminazione del cliente: {ex.Message}");
            }
        }
        #endregion

        #region Ordini
        public async Task SalvaOrdiniAsync(List<Ordine> ordini)
        {
            try
            {
                await _jsonService.SaveDataAsync(ordini, ORDINI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio degli ordini: {ex.Message}");
            }
        }

        public async Task<List<Ordine>> CaricaOrdiniAsync()
        {
            try
            {
                return await _jsonService.LoadDataAsync<Ordine>(ORDINI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel caricamento degli ordini: {ex.Message}");
            }
        }

        public async Task SalvaOrdineAsync(Ordine ordine)
        {
            try
            {
                var ordini = await CaricaOrdiniAsync();
                ordini.Add(ordine);
                await SalvaOrdiniAsync(ordini);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio dell'ordine: {ex.Message}");
            }
        }
        #endregion

        #region Prodotti
        public async Task SalvaProdottiAsync(List<Prodotto> prodotti)
        {
            try
            {
                await _jsonService.SaveDataAsync(prodotti, PRODOTTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio dei prodotti: {ex.Message}");
            }
        }

        public async Task<List<Prodotto>> CaricaProdottiAsync()
        {
            try
            {
                return await _jsonService.LoadDataAsync<Prodotto>(PRODOTTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel caricamento dei prodotti: {ex.Message}");
            }
        }
        #endregion

        #region Ingredienti
        public async Task SalvaIngredientiAsync(List<Ingrediente> ingredienti)
        {
            try
            {
                await _jsonService.SaveDataAsync(ingredienti, INGREDIENTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel salvataggio degli ingredienti: {ex.Message}");
            }
        }

        public async Task<List<Ingrediente>> CaricaIngredientiAsync()
        {
            try
            {
                return await _jsonService.LoadDataAsync<Ingrediente>(INGREDIENTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nel caricamento degli ingredienti: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        public async Task<bool> EsisteDatoAsync(string fileName)
        {
            return _jsonService.FileExists(fileName);
        }

        public async Task EliminaTuttiDatiAsync()
        {
            try
            {
                await _jsonService.DeleteFileAsync(RISTORANTI_FILE);
                await _jsonService.DeleteFileAsync(CLIENTI_FILE);
                await _jsonService.DeleteFileAsync(ORDINI_FILE);
                await _jsonService.DeleteFileAsync(DIPENDENTI_FILE);
                await _jsonService.DeleteFileAsync(PRODOTTI_FILE);
                await _jsonService.DeleteFileAsync(INGREDIENTI_FILE);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nell'eliminazione dei dati: {ex.Message}");
            }
        }

        // Metodo per inizializzare i dati se non esistono
        public async Task InizializzaDatiAsync()
        {
            try
            {
                if (!await EsisteDatoAsync(RISTORANTI_FILE))
                {
                    await SalvaRistorantiAsync(new List<Ristorante>());
                }
                
                if (!await EsisteDatoAsync(CLIENTI_FILE))
                {
                    await SalvaClientiAsync(new List<Cliente>());
                }
                
                if (!await EsisteDatoAsync(ORDINI_FILE))
                {
                    await SalvaOrdiniAsync(new List<Ordine>());
                }
                
                if (!await EsisteDatoAsync(PRODOTTI_FILE))
                {
                    await SalvaProdottiAsync(new List<Prodotto>());
                }
                
                if (!await EsisteDatoAsync(INGREDIENTI_FILE))
                {
                    await SalvaIngredientiAsync(new List<Ingrediente>());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore nell'inizializzazione dei dati: {ex.Message}");
            }
        }
        #endregion
    }
}