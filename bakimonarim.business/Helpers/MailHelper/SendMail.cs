using bakimonarim.core.Utilities.Results;
using System.Net.Mail;

namespace bakimonarim.business.Helpers.MailHelper
{
    //Güvenliği Geliştirilecek. Ve Mail Servis Değişecek.
    public class SendMail
    {
        IDailyReportHelper _dailyReportHelper;
        public SendMail(IDailyReportHelper dailyReportHelper)
        {
            _dailyReportHelper = dailyReportHelper;
        }
        public static IResult SendDailyReport(string _body)
        {
            string subject = "Wapp - Donanım Silme İşlemi";
            string body = _body;
            string FromMail = "report@wappsmtp.com";
            string emailTo = "dev.burvkv@gmail.com"; // support@tw-crm.com
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("webmail.arcaservis.com");
            mail.From = new MailAddress(FromMail);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("report@wappsmtp.com", "Kl.49123871982!527**");
            SmtpServer.EnableSsl = false;
            SmtpServer.Send(mail);

            return new SuccessResult("Rapor Gönderildi.");
        }
    }
}
