using System.Net.Mail;

namespace BadCodeExamples
{
    public class EmailSender
    {

        public void Send()
        {
            var email = new MailMessage
            {
                Sender = new MailAddress("DisplayName", "From"),
                Subject = "Subject",
                From = new MailAddress("DisplayName", "From")
            };
            using var smtp = new SmtpClient();
            smtp.SendAsync(email, "token");
        }

    }


    public class NotificationService
    {

        public void SendNotification()
        {
            var email = new MailMessage
            {
                Sender = new MailAddress("DisplayName", "From"),
                Subject = "Subject",
                From = new MailAddress("DisplayName", "From")
            };
            using var smtp = new SmtpClient();
            smtp.SendAsync(email, "token");
        }

    }


    public class Worker()
    {
        void DoSomething()
        {
            var sender = new EmailSender();
            sender.Send();
        }
    }


    public class Worker2()
    {
        void DoSomething()
        {
            var sender = new NotificationService();
            sender.SendNotification();
        }
    }
}
//нарушены принцип DRY и закон деметры  классы слишко разделены когда можно было бы написать одну раз отпрвку сообщений её написали дважды