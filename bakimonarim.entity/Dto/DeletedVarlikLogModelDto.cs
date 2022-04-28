using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.entity.Dto
{
    public class DeletedVarlikLogModelDto
    {
        public string VarlikKodu { get; set; }
        public string VarlikAdi { get; set; }
        public string GrupAdi { get; set; }
        public string SilenKullanici { get; set; }
        public string Date { get; set; }

    }
}
