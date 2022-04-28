using bakimonarim.core.Entity;

namespace bakimonarim.entity
{
    public class VGrup : IEntity
    {
        public int GrupID { get; set; }
        public int AracSinifID { get; set; }
        public string GrupMarka { get; set; }
        public string GrupModel { get; set; }
        public string LastikTip { get; set; }
    }
}
