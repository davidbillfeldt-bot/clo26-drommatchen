public class Match
{
    // Privata fält
    public string _hemmalag { get; private set; }
    public string _bortalag { get; private set; }
    public string _datum { get; private set; }

    // Properties — publik get, privat set
    public string Hemmalag { get; private set; }

    public string Bortalag {  get; private set; }
    public string Datum {  get; private set; }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
       _bortalag = hemmalag;
       _bortalag = bortalag;
       _datum = datum;
        Match match1 = new Match("T1", "G2", "2026-09-17");
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        // TODO
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO
    }
}
