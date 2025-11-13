namespace PoddApp.Models
{
    public class Poddflöde
    {
        public string Id { get; set; } = ""; // Används för MongoDB
        public string Namn { get; set; } = ""; // Namn användaren gett flödet 
        public string Url { get; set; } = "";// RSS-adressen 
        public string Kategori { get; set; } = ""; // För att organisera prenumerationer 
        public List<Avsnitt> Avsnitt { get; set; } // Lista över tillhörande avsnitt
        public int Uppdateringsintervall { get; set; } 
    }
}
