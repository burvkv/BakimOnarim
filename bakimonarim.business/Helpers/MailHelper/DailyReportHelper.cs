using bakimonarim.core.Utilities.Results;
using bakimonarim.entity.Dto;

namespace bakimonarim.business.Helpers.MailHelper
{
    public class DailyReportHelper : IDailyReportHelper
    {
        public IResult CreateDailyReport(DeletedVarlikLogModelDto varlik)
        {
            Dailyreport dailyReport = new Dailyreport
            {
                GrupAdi = varlik.GrupAdi,
                SilenKullanici = varlik.SilenKullanici,
                Date = DateTime.Now.ToString("HH.mm.ss dd/MM/yyyy"),
                Body = $"{varlik.VarlikKodu} Kodlu {varlik.VarlikAdi} {DateTime.Now.ToString("HH.mm.ss dd/MM/yyyy")} tarihinde {varlik.SilenKullanici} tarafından silindi.",

            };
            SendMail.SendDailyReport(dailyReport.Body);
            return new SuccessResult();

        }

    }
}
