using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class DataKunden
    {
 
        public List<Kunden> GetKunden ()
        { 
            List<Kunden> kundenListe = new();
            kundenListe.Add(new Kunden() { Kdnr = 1, Kurzname = "BGa", Vorname = "Bill", Nachname = "Gates", Geburtsdatum = new DateTime(1969, 07, 12), persoNr = "0001", FührerscheinNr = "1111", Email = "micro.soft@email.de", TelNr = "015498" });
            kundenListe.Add(new Kunden() { Kdnr = 2, Kurzname = "MZu", Vorname = "Mark", Nachname = "Zuckerberg", Geburtsdatum = new DateTime(1984, 04, 20), persoNr = "0666", FührerscheinNr = "6660", Email = "Lizard.mann@email.de", TelNr = "01666" });
            kundenListe.Add(new Kunden() { Kdnr = 3, Kurzname = "BOb", Vorname = "Barackus", Nachname = "Obamna", Geburtsdatum = new DateTime(1972, 05, 04), persoNr = "1234", FührerscheinNr = "2431", Email = "der.echtr@email.de", TelNr = "0165742" });
            kundenListe.Add(new Kunden() { Kdnr = 4, Kurzname = "CMa", Vorname = "Cahrl", Nachname = "Mahgs", Geburtsdatum = new DateTime(1848, 03, 01), persoNr = "1848", FührerscheinNr = "1848", Email = "die.revolution@email.de", TelNr = "01848" });
            kundenListe.Add(new Kunden() { Kdnr = 5, Kurzname = "JWh", Vorname = "Joe", Nachname = "Who", Geburtsdatum = new DateTime(1990, 09, 06), persoNr = "4548", FührerscheinNr = "7545", Email = "joe.who@email.de", TelNr = "017889" });
            kundenListe.Add(new Kunden() { Kdnr = 6, Kurzname = "JMa", Vorname = "Joe", Nachname = "Mama", Geburtsdatum = new DateTime(2000, 02, 04), persoNr = "4512", FührerscheinNr = "1104", Email = "joe.mama@email.de", TelNr = "014844" });
            kundenListe.Add(new Kunden() { Kdnr = 7, Kurzname = "DDa", Vorname = "Dreckiger", Nachname = "Dan", Geburtsdatum = new DateTime(1993, 08, 07), persoNr = "4849", FührerscheinNr = "8754", Email = "d.dreckiger@email.de", TelNr = "014884" });
            kundenListe.Add(new Kunden() { Kdnr = 8, Kurzname = "SLa", Vorname = "Spitzkopf", Nachname = "Larry", Geburtsdatum = new DateTime(1994, 11, 10), persoNr = "8742", FührerscheinNr = "7854", Email = "l.spitzkopf@email.de", TelNr = "0104523" });
            for(int i = 0; i < 30; i++)
            {
                kundenListe.Add(RandomKunde(9 + i));
            }
            return kundenListe;

        }

        List<String> vornamenListe = new()
        {
            "Anna",
            "Frieda",
            "Martha",
            "Erna",
            "Emma",
            "Marie",
            "Gertrud",
            "Margarete",
            "Maria",
            "Elisabeth",
            "Berta",
            "Karl",
            "Wilhelm",
            "Heinrich",
            "Hans",
            "Otto",
            "Hermann",
            "Paul",
            "Walter",
            "Friedrich",
            "Ernst",
            "Willi"
        };

        List<String> nachnamenListe = new()
        {
            "Melchior",
            "Goldberg",
            "Stellmacher",
            "Reder ",
            "Lipinski",
            "Eppler",
            "Beller",
            "Schrage",
            "Klingbeil",
            "Spörl",
            "Fett",
            "Eckhoff",
            "Rentsch",
            "Husemann",
            "Breier",
            "Schimmelpfennig",
            "Raupach",
            "Hinzmann",
            "Henrichs",
            "Forstner",
            "Dose"
        };

        public Kunden RandomKunde(int x)
        {
            Random rnd = new Random();
            String persoNr = rnd.Next(0, 10000).ToString();
            String führerscheinNr = rnd.Next(0, 10000).ToString();
            String telNr = "0" + rnd.Next(0, 1000000).ToString();
            String vorname = vornamenListe[rnd.Next(0, vornamenListe.Count())];
            String nachname = nachnamenListe[rnd.Next(0, nachnamenListe.Count())];
            String email = vorname + "." + nachname + "@email.de";
            String kurzname = vorname.Substring(0, 1) + nachname.Substring(0, 2);
            Kunden kunde = new Kunden() { Kdnr = x, Kurzname = kurzname, Vorname = vorname, Nachname = nachname, Geburtsdatum = RandomDay(), persoNr = persoNr , FührerscheinNr = führerscheinNr, Email = email, TelNr = telNr};
            return kunde;
        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2004, 12, 31);
          
            return start.AddDays(-gen.Next(1,20000));
        }
    }
}
