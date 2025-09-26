/*
Classe generica per gestione JSON che non va utilizzata direttamente nelle classi del McCadel 
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonManager
{
    public class JsonService
    {
        private readonly string _dataDirectory;
        private readonly JsonSerializerOptions _options;

        public JsonService(string dataDirectory = ".")
        {
            _dataDirectory = dataDirectory;
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                ReferenceHandler = ReferenceHandler.Preserve,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            
            if (!Directory.Exists(_dataDirectory))
            {
                Directory.CreateDirectory(_dataDirectory);
            }
        }

        // Salva una lista di oggetti
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

        // Carica una lista di oggetti
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
                
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return new List<T>();
                }

                return JsonSerializer.Deserialize<List<T>>(jsonString, _options) ?? new List<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento di {fileName}: {ex.Message}");
            }
        }

        // Salva un singolo oggetto
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

        // Carica un singolo oggetto
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
                
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return new T();
                }

                return JsonSerializer.Deserialize<T>(jsonString, _options) ?? new T();
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante il caricamento di {fileName}: {ex.Message}");
            }
        }

        // Verifica se un file esiste
        public bool FileExists(string fileName)
        {
            string filePath = Path.Combine(_dataDirectory, fileName);
            return File.Exists(filePath);
        }

        // Elimina un file
        public async Task DeleteFileAsync(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                if (File.Exists(filePath))
                {
                    await Task.Run(() => File.Delete(filePath));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Errore durante l'eliminazione di {fileName}: {ex.Message}");
            }
        }
    }
}