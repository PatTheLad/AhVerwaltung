using AhVerwaltung.Model;

namespace AhVerwaltung.Data
{
    public class VerträgeData
    {
        public List<Vertrag> GetVerträge(int anzahl)
        {
            Random rndm = new();
            List<Vertrag> tmpList = new();
            int count = 0;
            while(anzahl > count)
            {
                int vertragsdauer = rndm.Next(1, 2000);
                tmpList.Add(new Vertrag() { 
                    VertragsNr = count+1, 
                    KurzName = (vornamenListe[rndm.Next(0, vornamenListe.Count())].Substring(0, 1) + nachnamenListe[rndm.Next(0, nachnamenListe.Count())].Substring(0, 1)), 
                    RückgabeformularNr = rndm.Next(1, 999), 
                    Kennzeichen = $"{GenerateRandomString(2)}-{GenerateRandomString(2)}-{rndm.Next(1, 999)}", 
                    AbschlussDatum = DateTime.Now.AddDays(-rndm.Next(1, 3000)),
                    Vertragsdauer = vertragsdauer,
                    Preis = rndm.Next(5, 20) * vertragsdauer
                });
                count++;
            }
            return tmpList;
        }

        private static string GenerateRandomString(int länge)
        {
            Random rndm = new();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, länge).Select(s => s[rndm.Next(s.Length)]).ToArray());
        }

        private List<String> vornamenListe = new()
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
    }
}
