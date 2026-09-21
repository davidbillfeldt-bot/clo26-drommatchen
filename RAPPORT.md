# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  Drömmatchen
**Grupp:**  Team Hydra
**Datum:**  2026-09-17
**GitHub:**  https://github.com/davidbillfeldt-bot/clo26-drommatchen

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [David Billfeldt] | Zip + RAPPORT.md + REFLEKTION.md |
| [Namn 2] | REFLEKTION.md |
| [Namn 3] | REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna
Jag skapade klasserna Match och Spelare för att samla information på ett tydligt sätt. Match innehåller hemmalag, bortalag och datum, medan Spelare innehåller spelarens namn, nummer och position.
> 

### Metoderna
I klassen Match skapade jag metoden Presentera(), som skriver ut matchens lag och datum. Jag skapade också AnnounceraKillLeader(), som tar emot ett Spelare-objekt och skriver ut spelarens namn, nummer och position.
> 

### Main()
I Main() skapade jag objekt av klasserna Match och Spelare med hjälp av konstruktorn. Därefter anropade jag metoderna för att visa matchinformationen och informationen om en spelare.
> 

### Git
Jag använde Git för att spara ändringar i projektet under arbetets gång. På så sätt kunde jag följa utvecklingen och gå tillbaka till en tidigare version om något skulle bli fel.
> 

### Kodkvalitet
Jag använde tydliga klass-, metod- och variabelnamn för att göra koden lättare att förstå. Jag använde också properties med private set för att skydda informationen och undvek onödig upprepning i koden.
> 

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> 

### Varför vi löste det såhär

> 

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:
cb1af92 (HEAD -> main, origin/main, origin/HEAD) Removed unnesescary comment.
5513b7c Fixed on line 20 from return text to return spelare.Namn
ef9518b Ficed so Killeader got displayed on a single line
f136832 Removed unnesecary comments.
19db396 Fixed code hade new players in the konstruktor
a95914f Fixed the code hade new players inside the konstruktor.
4621e3a Added new Match.
59e1a2c Changed back an error in private string_ hemmalag;
815785a Added konstruktor for the match T1, G2, and the date
cbe6f04 Fixed a ; on line 21 making the code not work.
331dafc Added 2 new players with name, number and position
d0e166e Lage till get set private på lagen
35825ed Solutionfile added at root
34de7d5 refactor: gör property-kroppar tomma — studerande implementerar själva
66f4917 init: starterrepo för Drömmatchen (Inlämning 1)
PS C:\Users\david\source\repos\clo26-drommatchen> 
```
[klistra in här]
```