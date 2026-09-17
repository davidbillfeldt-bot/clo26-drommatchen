using System;
public class Match
{
    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }
    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }
    // Skriver ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} mot {Bortalag} - {Datum}");
    }
    // Skriver ut spelarens namn, nummer och position
    public void AnnounceraKillLeader(Spelare spelare)
    {
        Console.WriteLine(spelare.Namn);
        Console.WriteLine(spelare.Nummer);
        Console.WriteLine(spelare.Position);
    }
}