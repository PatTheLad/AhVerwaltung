using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class RückgabeformularData
    {

        public static List<Rückgabeformular> GetRueckgabeformular(int anzahl)
        {
            Random rndm = new();
            List<Rückgabeformular> tmpList = new();
            int count = 0;
            while (anzahl > count)
            {
                tmpList.Add(new Rückgabeformular() { RückgabeFormularNr = rndm.Next(1, 999), Anhänger = new Anhänger() { Kennzeichen = $"OE-AB-{rndm.Next(1, 999)}" }, Vertrag = new Vertrag() { VertragsNr = rndm.Next(1, 999) }, Vertragskunden = new Kunden() { Kurzname = RandomKundeKurzname() } });
                count++;
            }
            return tmpList;
        }
        static List<String> vornamenListe = new()
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

        static List<String> nachnamenListe = new()
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

        public static string RandomKundeKurzname()
        {
            Random rnd = new Random();

            string vorname = vornamenListe[rnd.Next(0, vornamenListe.Count())];
            string nachname = nachnamenListe[rnd.Next(0, nachnamenListe.Count())];
            string kurzname = vorname.Substring(0, 1) + nachname.Substring(0, 2);
            return kurzname;
        }


    }
}
