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
            return kundenListe;

        }
    }
}
