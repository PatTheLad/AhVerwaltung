namespace AhVerwaltung.Data
{
    public class AnhängerData
    {
        private static readonly List<string> Marken = new() { "Hornbach", "ATU", "OBI" };

        public static List<Model.Anhänger> GetAnhänger()
        {
            var anhänger = new List<Model.Anhänger>();
            for (int i = 0; i < 25; i++)
                anhänger.Add(new Model.Anhänger() { Kennzeichen = $"OE-AB-1{i}", Marke = Marken[Random.Shared.Next(0, 2)], Modell = $"D{i * 100}" });

            return anhänger;
        }
    }
}
