public class Match
{
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
    }
    
Match match1 = new Match("T1", "G2", "2026-09-17");
    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine(_hemmalag + " mot " + _bortalag + " - " +_datum);
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraKillLeader(Spelare spelare)
   
    {
        Console.WriteLine(spelare.Namn);
        Console.WriteLine(spelare.Nummer);
        Console.WriteLine(spelare.Position);
    }

}
