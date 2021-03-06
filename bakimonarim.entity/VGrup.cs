using bakimonarim.core.Entity;
using System.ComponentModel.DataAnnotations;

namespace bakimonarim.entity
{
    public class VGrup : IEntity
    {
        [Key]
        public long GrupID { get; set; }
        public long AracSinifID { get; set; }
        public string GrupMarka { get; set; }
        public string GrupModel { get; set; }
        public string LastikTip { get; set; }

        public ICollection<Varlik2> TBL_Varlik { get; set; }
    }
}
