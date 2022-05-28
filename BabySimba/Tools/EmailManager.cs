using System.Net.Mail;

namespace BabySimba.Tools
{
    public class EmailManager
    {
        // 객체생성없이 사용 가능하도록 static method로 구현
        public static void Send(string to, string subject, string contents)
        {
            string sender = "do_not_reply@test.com";

            string smtpHost = "smtp.com";
            int smtpPort = 2525;

            string smtpId = "id";
            string smtpPwd = "password";

            MailMessage mailMsg = new MailMessage();
            mailMsg.From = new MailAddress(sender); // to, cc, 숨은참조 등 모두 mailaddress로 설정
            mailMsg.To.Add(new MailAddress(to)); // To는 MailAddressCollections임
            mailMsg.To.Add(to); // string으로 바로 적어도 됨. ,로 구분된 여러 메일주소가 될 수도 있음. (ex. example@test.com,example2@test.com)

            mailMsg.Subject = subject;
            mailMsg.IsBodyHtml = true;
            mailMsg.Body = contents; // mail body
            mailMsg.Priority = MailPriority.Normal; // 메일 중요도

            // 이제 smtp Client 객체 이용해서 server로 보내면 됨.
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new System.Net.NetworkCredential(smtpId, smtpPwd);
            smtpClient.Host = smtpHost;
            smtpClient.Port = smtpPort;
            smtpClient.Send(mailMsg);

        }
    }
}
