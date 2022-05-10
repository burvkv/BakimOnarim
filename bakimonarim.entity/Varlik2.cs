using bakimonarim.core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.entity
{
    public class Varlik2:IEntity
    {
        [Key]
        public int VarlikID { get; set; }
        public int GrupID { get; set; }
        public string VarlikAdi { get; set; }
        public string VarlikKodu { get; set; }
        public DateTime KayitTarihi { get; set; }

        public VGrup TBL_VGrup { get; set; }
    }
}
