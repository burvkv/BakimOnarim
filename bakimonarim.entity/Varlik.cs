using bakimonarim.core.Entity;

namespace bakimonarim.entity
{
    public class Varlik : IEntity
    {
        public int VarlikID { get; set; }
        public string VarlikKodu { get; set; }
        public string VarlikAdi { get; set; }
        public DateTime KayitZamani { get; set; }    
        public int GrupID { get; set; }
        public string Renk { get; set; }
        public int KM { get; set; }
        public string Plaka { get; set; }
        public string SaseNo { get; set; }
        public string MotorNo { get; set; }
        public string BuskiNo { get; set; }
        public string Ilce { get; set; }
        public int Yil { get; set; }
        public int Saat { get; set; }
        public string LastikEbat { get; set; }
        public int LastikSayi { get; set; }
        public string Sube { get; set; }
        public int DuzenleyenKullaniciId { get; set; }
    }
}
