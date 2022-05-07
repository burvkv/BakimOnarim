using System.ComponentModel.DataAnnotations;
using bakimonarim.core.Entity;

namespace bakimonarim.entity
{
    public class Malzeme:IEntity
    {
        [Key]
        public long MalzemeID { get; set; }
        public string MalzemeAd { get; set; }
        public string Birim { get; set; }
        public string? BirimFiyat { get; set; }
        public int? Adet { get; set; }
    }
}