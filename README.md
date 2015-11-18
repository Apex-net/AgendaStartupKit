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

0.  `File > New > Project`
0.  Selezionare template `Agenda Web Application (MVC4)` nel percorso `Installed > Templates > Visual C# > Web`


## Note per gli sviluppatori

:warning: Queste note sono per gli sviluppatori di `AgendaStartupKit`. Se volete soltanto usare questi template, queste note non vi sono necessariamente utili.

### Come esportare

0. Assicurare di avere salvato tutte le modifiche
0. Lanciare `script\prepare_startupKit_for_export.bat`
0. `File > Export Template...`
0. Project template
0. Selezionare il progetto (ad esempio: `WebMVC4`)
0. Compilare i campi:
   - `Template name:` **Agenda Web Application (MVC4)**
   - `Template description:` **Template progetto con MVC4, EF5 e materializecss**
   - `Output location:` dovrebbe essere compilato in automatico (ad esempio: `C:\Users\a.donmez\Documents\Visual Studio 2013\My Exported Templates\Agenda Web Application (MVC4).zip`)
   - (Opzionale) `Automatically import the template into Visual Studio:` _selezionato_ (vedi [come installare](#come-installare))
