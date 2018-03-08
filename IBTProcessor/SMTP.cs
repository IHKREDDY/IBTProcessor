using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.ComponentModel;

namespace IBTProcessor
{
    class SMTP
    {

        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;
            if (e.Error != null)
            {

                //logging to be impplemented
                //Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                //logging to be implemented
                //Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }
        public static void SendEmail(string fromAddress,string toAddress,string messageSubject,string messageBody)
        {
           
            //get host from config file
            SmtpClient client = new SmtpClient();

            // Specify the e-mail sender.
            MailAddress from = new MailAddress(fromAddress);

            // Set destinations for the e-mail message.
            MailAddress to = new MailAddress(toAddress);

            // Specify the message content.
            MailMessage message = new MailMessage(from, to);
            message.Body = messageBody;

            // Specify the message subject.
            message.Subject = messageSubject;
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);

            // The userState can be any object that allows your callback 
            // method to identify this send operation.
            string userState = "IBT Message";
            client.SendAsync(message, userState);
            // Clean up.
            message.Dispose();
        }
    }
}
