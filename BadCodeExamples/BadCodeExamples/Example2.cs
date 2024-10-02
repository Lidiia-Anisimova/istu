using System.Net.Mail;

namespace BadCodeExamples
{
    //Нарушены принципы DRY - don't repeat your self
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

    //Нарушены принципы DRY - don't repeat your self
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
