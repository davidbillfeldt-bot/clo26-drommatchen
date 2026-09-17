public class Spelare
{
    // Privata fält
    public string _namn { get; private set; }
    public int _nummer { get; private set; }
    public string _position { get; private set; }

    // Properties — publik get, privat set

    public string Namn { get; private set; }


    public int Nummer { get; private set; }
    // Skapa get och privat set för Nummer

    public string Position { get; private set; }
    // Skapa get och privat set för Position


    // Konstruktor
    public Spelare(string namn, int nummer, string position)
    {
        _namn = namn;
        _nummer = nummer;
        _position = position;

    }

    //Tog hjälp av Ai på rad 21 då jag hade skrivt ett ; efter raden som strulade till koden:)
   
    Spelare spelare1 = new Spelare("Faker", 7, "Midlane");
    Spelare spelare2 = new Spelare("Caps", 10, "Midlane");

    // TODO: tilldela de privata fälten
}