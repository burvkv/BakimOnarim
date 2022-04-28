using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.Helpers.MailHelper
{
    public class Dailyreport
    {
        private string _title = "Varlık Silme İşlemi";
        public string VarlikAdi { get; set; }
        public string VarlikKodu { get; set; }
        public string GrupAdi { get; set; }
        public string SilenKullanici { get; set; }
        public string Title { get { return _title; } }
        public string Body { get; set; }
        public string Date { get; set; }
        
    }
}
