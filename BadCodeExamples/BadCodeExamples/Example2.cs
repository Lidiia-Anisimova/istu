using System.Net.Mail;

namespace BadCodeExamples // Большое кол-во классов (KISS), повторений (DRY)
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
            using var smtp = new SmtpClient(); // не нужное использовение using т.к добавленна библиотека using System.Net.Mail
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
            using var smtp = new SmtpClient(); // не нужное использовение using т.к добавленна библиотека using System.Net.Mail
            smtp.SendAsync(email, "token");
        }

    } // Классы NotificationService и EmailSender имеют одинаковый код (DRY)


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
    } //Классы и методы содержат одинаковые названия (DRY)
}   
