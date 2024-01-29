using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace RegistrationForm
{
     class EmailSending
    {
        static void Main(string[] args)
        {
            EmailSending emailSending = new EmailSending();
            emailSending.TestEmail();
        }
        void TestEmail()
        {
            try
            {
            var client = new SmtpClient();
            client.Connect("sandbox.smtp.mailtrap.io", 25, false);
            client.Authenticate("779b290f109a4b", "737dc2ebdd1809");
            var bodyBuilder = new BodyBuilder()
            {
                TextBody = "Hello,its my first mail testing from Tanmes"
            };
            var sendEmail = new MimeMessage()
            {
                From = { new MailboxAddress("from", "from@example.com") },
                To = { new MailboxAddress("To", "To@example.com") },
                Subject = "Testing Email",
                Body=bodyBuilder.ToMessageBody()
            };
            client.Send(sendEmail);
            client.Disconnect(true);
                Console.WriteLine("Email Sent");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
