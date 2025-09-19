# Sample Data per Clienti e Personale

Questa implementazione fornisce dati di esempio per clienti e dipendenti del sistema McCadel Desktop.

## File JSON di Esempio

### `Data/dipendenti.json`
Contiene 8 dipendenti di esempio con i seguenti dati:
- Nome
- Cognome  
- Stipendio

Esempio di struttura:
```json
[
  {
    "nome": "Marco",
    "cognome": "Rossi",
    "stipendio": 1800.0
  }
]
```

### `Data/clienti.json`
Contiene 10 clienti di esempio con i seguenti dati:
- Nome
- Cognome
- Ordine (opzionale, alcuni clienti hanno ordini attivi)

Esempio di struttura:
```json
[
  {
    "nome": "Giovanni",
    "cognome": "Ferrari",
    "ordine": null
  },
  {
    "nome": "Maria",
    "cognome": "Esposito",
    "ordine": {
      "numeroTavolo": 5,
      "prodotti": [],
      "nomeCliente": "Maria",
      "cognomeCliente": "Esposito",
      "prezzoTotale": 25.50
    }
  }
]
```

## Come Utilizzare i Dati di Esempio

### 1. Caricamento Automatico
Utilizzare la classe `SampleDataLoader` per caricare automaticamente tutti i dati:

```csharp
var ristorante = new Ristorante("McCadel", "Via Roma 123");
var sampleLoader = new SampleDataLoader();

// Carica tutti i dati di esempio
await sampleLoader.CaricaDatiEsempioAsync(ristorante);

Console.WriteLine($"Dipendenti caricati: {ristorante.Dipendenti.Count}");
Console.WriteLine($"Clienti caricati: {ristorante.Clienti.Count}");
```

### 2. Caricamento Selettivo
Caricare solo dipendenti o solo clienti:

```csharp
var sampleLoader = new SampleDataLoader();

// Solo dipendenti
await sampleLoader.CaricaDipendentiEsempioAsync(ristorante);

// Solo clienti
await sampleLoader.CaricaClientiEsempioAsync(ristorante);
```

### 3. Verifica Esistenza File
Controllare se i file di esempio esistono:

```csharp
var sampleLoader = new SampleDataLoader();
if (sampleLoader.EsistonoDatiEsempio())
{
    // I file esistono, procedi con il caricamento
    await sampleLoader.CaricaDatiEsempioAsync(ristorante);
}
```

### 4. Salvataggio Dati come Esempio
Salvare i dati correnti del ristorante come nuovi dati di esempio:

```csharp
var sampleLoader = new SampleDataLoader();
await sampleLoader.SalvaDatiComeEsempioAsync(ristorante);
```

## Integrazione con DataManager

I dati di esempio sono compatibili con il sistema `DataManager` esistente:

```csharp
// Carica dati di esempio
var sampleLoader = new SampleDataLoader();
await sampleLoader.CaricaDatiEsempioAsync(ristorante);

// Salva tutto tramite DataManager
var dataManager = new DataManager();
await dataManager.SalvaRistoranteCompletoAsync(ristorante);

// Ricarica dal backup completo
var ristoranteCaricato = await dataManager.CaricaRistoranteCompletoAsync();
```

## Struttura dei File

```
Data/
├── dipendenti.json      # 8 dipendenti di esempio
├── clienti.json         # 10 clienti di esempio
└── (altri file generati dal sistema)
```

## Note Tecniche

1. **Formato JSON**: I file utilizzano il formato JSON standard con naming camelCase
2. **Compatibilità**: I dati sono compatibili con le classi `DipendenteDati` e `ClienteDati` del `DataManager`
3. **Estensibilità**: È possibile aggiungere nuovi dati modificando i file JSON
4. **Ordini**: Alcuni clienti hanno ordini di esempio (senza prodotti per semplicità)

## Risoluzione Problemi

Se i file JSON non vengono caricati:
1. Verificare che esistano i file `Data/dipendenti.json` e `Data/clienti.json`
2. Controllare che la directory `Data` sia accessibile
3. Verificare che i file JSON abbiano una sintassi valida
4. Assicurarsi che l'applicazione abbia i permessi di lettura sui file