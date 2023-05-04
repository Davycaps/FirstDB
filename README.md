DESCRIZIONE PROGETTO FIRSTDB

1)COME CREARE UN PROGETTO CON DOTNET NEW CONSOLE \
-Aprire una nuova cartella vuota già creata con visual studio code

![image](https://user-images.githubusercontent.com/116790994/235083107-2d1af128-d52f-44e2-af16-2ee77026ef4f.png 250x250)

-aprire il terminale
-digitare: "dotnet new console"

2)COME INCLUDERE LA LIBRERIA SQLITE
-digitare nel terminale:"dotnet add package sqlite-net-pcl"

3)DOVE TROVARE E SCARICARE IL DIAGRAMMA RELAZIONALE DEL "DB CHINOOK.DB" 
https://www.sqlitetutorial.net/sqlite-sample-database/ 

4)CODICE NECESSARIO PER VISUALIZZARE TUTTI GLI ARTISTI 
```
using SQLite; 
//connessione al database 

SQLiteConnection cn1 = new SQLiteConnection("chinook.db"); 

var tblArtists = cn1.Query<Artist>("select * from artists");

Console.WriteLine( $"in questa tabella cisono {tblArtists.Count} record");

//fine main... inizio dichiarazioni classi----------------------- 
public class Artist 
{ 
    public int ArtistId{get;set;} 
    public string Name{get;set;} 
} 
```





