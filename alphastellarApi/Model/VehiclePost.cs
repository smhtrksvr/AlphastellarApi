namespace alphastellarApi.Model
{
    public class VehiclePost
    {
        public Depo Depo { get; set; }
        public int SecilenAracSayisi { get; set; }
    }

    public class Depo
    {
        public string DepoAdi { get; set; }
        public List<Arac> Araclar { get; set; }
    }
    
    public class Arac
    {
        public int Id { get; set; }
        public string Aracturu { get; set; }
       // public int AracAdedi { get; set; }
        public bool Farlar { get; set; }
        public bool FarlarAcik { get; set; }
        public bool Tekerlek { get; set; }
        public string Renk { get; set; }
    }
}
