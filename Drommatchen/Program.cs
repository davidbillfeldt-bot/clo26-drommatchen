// Skapa minst 2 spelare
Spelare spelare1 = new Spelare("Faker", 7, "Midlane");
Spelare spelare2 = new Spelare("Caps", 10, "Midlane");

// Skapa 1 match
Match match = new Match("T1", "G2", "2026-09-17");

// Anropa match.Presentera()
match.Presentera();

// Anropa match.AnnounceraMålskytt() med båda spelarna
match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);