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
    public string AnnounceraKillLeader(Spelare spelare)
    {
        string text = $"{spelare.Namn} {spelare.Nummer} {spelare.Position}";
        Console.WriteLine(text);
        return text;
    }
}