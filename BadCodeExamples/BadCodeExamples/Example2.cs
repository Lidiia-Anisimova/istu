using System.Net.Mail;

namespace BadCodeExamples
{
    public class EmailSender //Этот код имеет дублирование отправки электронной почты в классах EmailSender и NotificationService.
                             //Это нарушает принцип KISS
                             //Классы EmailSender и NotificationService имеют одинаковый функционал, но используются в разных местах.
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
