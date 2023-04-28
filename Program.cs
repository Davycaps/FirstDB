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