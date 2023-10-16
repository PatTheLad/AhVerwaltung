using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class DataKunden
    {
 
        public List<Kunden> GetKunden ()
        { 
            List<Kunden> kundenListe = new();
            kundenListe.Add(new Kunden() { Kdnr = 1, Kurzname = "BGa", Vorname = "Bill", Nachname = "Gates", Geburtsdatum = new DateTime(1969, 07, 12) });
            kundenListe.Add(new Kunden() { Kdnr = 2, Kurzname = "MZu", Vorname = "Mark", Nachname = "Zuckerberg", Geburtsdatum = new DateTime(1984, 04, 20) });
            kundenListe.Add(new Kunden() { Kdnr = 3, Kurzname = "BOb", Vorname = "Barackus", Nachname = "Obamna", Geburtsdatum = new DateTime(1972, 05, 04) });
            kundenListe.Add(new Kunden() { Kdnr = 4, Kurzname = "CMa", Vorname = "Cahrl", Nachname = "Mahgs", Geburtsdatum = new DateTime(1848, 03, 01) });
            kundenListe.Add(new Kunden() { Kdnr = 5, Kurzname = "JWh", Vorname = "Joe", Nachname = "Who", Geburtsdatum = new DateTime(1990, 09, 06) });
            kundenListe.Add(new Kunden() { Kdnr = 6, Kurzname = "JMa", Vorname = "Joe", Nachname = "Mama", Geburtsdatum = new DateTime(2000, 02, 04) });
            kundenListe.Add(new Kunden() { Kdnr = 7, Kurzname = "DDa", Vorname = "Dreckiger", Nachname = "Dan", Geburtsdatum = new DateTime(1993, 08, 07) });
            kundenListe.Add(new Kunden() { Kdnr = 8, Kurzname = "SLa", Vorname = "Spitzkopf", Nachname = "Larry", Geburtsdatum = new DateTime(1994, 11, 10) });
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
      
            String vorname = vornamenListe[rnd.Next(0, vornamenListe.Count())];
            String nachname = nachnamenListe[rnd.Next(0, nachnamenListe.Count())];
            String kurzname = vorname.Substring(0, 1) + nachname.Substring(0, 2);
            Kunden kunde = new Kunden() { Kdnr = x, Kurzname = kurzname, Vorname = vorname, Nachname = nachname, Geburtsdatum = RandomDay() };
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
