# AgendaStartupKit

Progetto template con cui partire coi nuovi progetti simil-agenda.


## Come installare

0. Scaricare l'ultima versione [qui](https://github.com/Apex-net/AgendaStartupKit/releases)
0. Copiare zip scaricato in (ad esempio) `C:\Users\a.donmez\Documents\Visual Studio 2013\Templates\ProjectTemplates\Visual C#\Web`

| :warning: |
| :--- |
| Il percorso esatto potrebbe cambiare in base alla versione di Visual Studio ed, ovviamente, il nome utente. |
| Per non confondersi cancellare eventuali versioni precedenti. |
| Se il percorso (od una sua parte) non esiste, potrebbe essere sufficiente crearlo. |
| Di solito i template nuovi sono subito disponibili, ma nel dubbio reavviare Visual Studio. |


## Come usare

Nel Visual Studio:

0. `File > New > Project`
0. Selezionare template `Agenda Web Application (MVC4)` nel percorso `Installed > Templates > Visual C# > Web`
0. Compilare i restanti dei campi (ad es.: nomi, percorso, ecc.)

| :warning: |
| :--- |
| Poiché questi template funzionino, bisogna assicurare che la solution Visual Studio sia in un livello superiore rispetto al progetto; altrimenti i riferimenti ai pacchetti installati via NuGet saranno errati. Nel "wizard", selezionare checkbox "Create directory for solution" dovrebbe fare questo. |


## Note per gli sviluppatori

:information_source: Queste note sono per gli sviluppatori di `AgendaStartupKit`. Se volete soltanto usare questi template, queste note non vi sono necessariamente utili.

### Come esportare

0. Assicurare di avere salvato tutte le modifiche
0. Lanciare `script\prepare_startupKit_for_export.bat` (questo script vi modificherà diversi file che alla fine di questa procedura dovranno essere "annullati" manualmente e/o tramite `git`)
0. Nel Visual Studio: `File > Export Template...`
0. Selezionare `Project template` (dovrebbe essere gia selezionato)
0. Selezionare il progetto (ad esempio: `WebMVC4`)
0. Compilare i campi in base al template progetto (ad esempio):
   - `Template name:` **Agenda Web Application (MVC4)**
   - `Template description:` **Template progetto con MVC4, EF5 e materializecss**
   - `Output location:` dovrebbe essere compilato in automatico (ad esempio: `C:\Users\a.donmez\Documents\Visual Studio 2013\My Exported Templates\Agenda Web Application (MVC4).zip`)
   - (Opzionalmente selezionare durante lo sviluppo) `Automatically import the template into Visual Studio` (vedi [come installare](#come-installare) per la modalità di installazione migliore)

### Come rilasciare

0. Creare un tag in `git` usando [Semantic Versioning](http://semver.org/) (ad esempio: `v0.1`)
0. Dopo aver pubblicato questo tag in GitHub, creare una release a partire da quest'ultimo, quindi caricare zip esportato (vedi [come esportare](#come-esportare)) usando il seguente "naming convention": (ad esempio) `AgendaStartupKit.WebMVC4-v0.1.zip`)
