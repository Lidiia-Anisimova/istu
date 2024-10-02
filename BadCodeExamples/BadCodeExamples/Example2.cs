using System.Net.Mail;

namespace BadCodeExamples
{
    public class EmailSender
    {
        //Нарушение DRY
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
        //Нарушение DRY
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
