/*
Classe generica che non va utilizzata direttamente nelle classi del McCadel 🙏
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Classi.Services
{
    public class JsonService
    {
        private readonly string _dataDirectory;
        private readonly JsonSerializerOptions _options;

        public JsonService(string dataDirectory = "Data") //In "Data" inserirò i json
        {
            _dataDirectory = dataDirectory;
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                ReferenceHandler = ReferenceHandler.IgnoreCycles, // #NoAlleDipendenzeCircolari
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            // Controllo se il folder "Data" esiste 
            if (!Directory.Exists(_dataDirectory))
            {
                Directory.CreateDirectory(_dataDirectory);
            }
        }

        // Salvare i dati
        public async Task SaveDataAsync<T>(List<T> data, string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                string jsonString = JsonSerializer.Serialize(data, _options);
                await File.WriteAllTextAsync(filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio di {fileName}: {ex.Message}");
            }
        }

        // Caricare i dati
        public async Task<List<T>> LoadDataAsync<T>(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                
                if (!File.Exists(filePath))
                {
                    return new List<T>();
                }

                string jsonString = await File.ReadAllTextAsync(filePath);
                return JsonSerializer.Deserialize<List<T>>(jsonString, _options) ?? new List<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento di {fileName}: {ex.Message}");
            }
        }

        // Salvare un singolo dato
        public async Task SaveSingleAsync<T>(T data, string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                string jsonString = JsonSerializer.Serialize(data, _options);
                await File.WriteAllTextAsync(filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il salvataggio di {fileName}: {ex.Message}");
            }
        }

        // Caricare un singolo dato
        public async Task<T> LoadSingleAsync<T>(string fileName) where T : new()
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                
                if (!File.Exists(filePath))
                {
                    return new T();
                }

                string jsonString = await File.ReadAllTextAsync(filePath);
                return JsonSerializer.Deserialize<T>(jsonString, _options) ?? new T();
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento di {fileName}: {ex.Message}");
            }
        }
    }
}




































































// Cadel Evans dopato