using bakimonarim.core.Entity;
using System.ComponentModel.DataAnnotations;

namespace bakimonarim.entity
{
    public class VGrup : IEntity
    {
        [Key]
        public int GrupID { get; set; }
        public int AracSinifID { get; set; }
        public string GrupMarka { get; set; }
        public string GrupModel { get; set; }
        public string LastikTip { get; set; }
    }
}
