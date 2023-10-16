namespace AhVerwaltung.Data
{
    public class AnhängerData
    {
        private static readonly List<string> _marken = new() { "Hornbach", "ATU", "OBI", "Stema", "Humbaur" };

        public static List<Model.Anhänger> GetAnhänger(int anzahl)
        {
            Random rndm = new();
            List<Model.Anhänger> anhänger = new();

            for (int i = 0; i < anzahl; i++)
                anhänger.Add(new Model.Anhänger() 
                { 
                    Kennzeichen = $"{GenerateRandomString(2)}-{GenerateRandomString(2)}-{rndm.Next(1, 999)}",
                    Marke = _marken[rndm.Next(0, 3)], 
                    Modell = $"{GenerateRandomString(1)}{rndm.Next(10, 999)}" 
                });

            return anhänger;
        }

       private static string GenerateRandomString(int länge)
       {
           Random rndm = new();
           var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
           return new string(Enumerable.Repeat(chars, länge).Select(s => s[rndm.Next(s.Length)]).ToArray());
       }
    }
}
