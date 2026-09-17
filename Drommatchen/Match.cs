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
    public void Presentera()
    { Console.WriteLine($"{Hemmalag} mot {Bortalag} - {Datum}"); }
    public void AnnounceraKillLeader(Spelare spelare)
    {   Console.WriteLine(spelare.Namn);
        Console.WriteLine(spelare.Nummer);
        Console.WriteLine(spelare.Position);}
}