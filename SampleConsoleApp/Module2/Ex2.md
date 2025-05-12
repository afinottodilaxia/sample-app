# Esercizio 2: Few-Shot + Chain of Thoughts Prompt

**Obiettivo:**  
Mettere in pratica la combinazione di “few-shot prompting” e “chain of thought prompting” per generare codice più strutturato e guidato.

**Consegna:**  
1. **Inserisci il seguente prompt** come commento nel progetto:
    ```csharp
    // Esempio: dato l'array [2, 4, 5, 6, 7, 8], la funzione dovrebbe restituire [2, 5, 7].
    // Per determinare se un numero è primo, segui questi passaggi:
    // 1. Verifica che il numero sia maggiore di 1.
    // 2. Controlla se il numero ha divisori da 2 fino a √numero.
    // 3. Se non ne ha, aggiungilo alla lista dei primi.
    // Crea una funzione in C# che implementi questa logica.
    ```
2. **Lascia che Copilot generi la funzione** sulla base del prompt dettagliato.
3. **Analizza il risultato**:
    - La funzione generata rispetta i passaggi suggeriti?
    - L’esempio fornito è stato utile per guidare Copilot?
4. **Esercitazione:** Proponi possibili miglioramenti al prompt o al codice generato (ad esempio: gestione di numeri negativi, input null, eccezioni, ottimizzazioni).