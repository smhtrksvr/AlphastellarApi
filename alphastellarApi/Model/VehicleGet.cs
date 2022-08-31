namespace alphastellarApi.Model
{
    public class VehicleGet
    {
        public bool AracSecilebilir { get; set; }
        public List<Ozellik> Arac { get; set; }
    }
    public class Ozellik
    { 
        public string AracAdi { get; set; }
       // public int AracAdedi { get; set; }
        public int AracId { get; set; }
        public bool FarlarVar { get; set; }
        public  bool Farlaracik { get ; set; }
        public bool TekerlekVar { get; set; }
        public string AracRengi { get; set; }
        

    }
}
