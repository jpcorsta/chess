using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace MailApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // create a new mime message object which we are going to use to fill the message data.
            MimeMessage message= new MimeMessage();
            // add the sender info that will apear in the email message
            message.From.Add(new MailboxAddress("Tester", "jpcorsta@mail.com"));

            //add the receiver mail address
            message.To.Add(MailboxAddress.Parse("jpcorsta@mail.com"));

            //add the message subject
            message.Subject = "Wuuf!";

            //add the message body as plain text the "plain" string passed to the TextPart indicates that it's plain text.
            //indicates that its plain text and not html for example
            message.Body = new TextPart("plain")
            {
                Text = @"Yes,
                Hello!.
                This is dog!."
            };

            //ask the user to enter the email
            Console.WriteLine("Email: ");
            string emailAddress = Console.ReadLine();
            //ask the user to enter the password
            Console.WriteLine("Password: ");

            //for security reasons we need to mask the password, to do that we will turn the console background and forground color to green
            // Store original values of the console's background and foreground color
            ConsoleColor originalBGColor = Console.BackgroundColor;
            ConsoleColor originalFGColor = Console.ForegroundColor;
            //set theh console's background and foreground to red for example.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            //read the password
            string password = Console.ReadLine();

            //set the console's background and foreground colors back to the original values we stored  earlier
            Console.BackgroundColor = originalBGColor;
            Console.ForegroundColor = originalFGColor;

            //create a new Smtp client
            SmtpClient client= new SmtpClient();

            try
            {
                //connect to the gmail smtp server using port 465 with ssl enabled
                client.Connect("smtp.gmail.com", 465, true);
                // Note: only needed if the SMTP server requires authentication, like gmail for example
                client.Authenticate(emailAddress, password);
                client.Send(message);

                //display if no exeption was thrown
                Console.WriteLine("Email sent!.");
            }
            catch (Exception ex)
            {
                //in case of an error display the message.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //At any case disconnect
                client.Disconnect(true);
                //and dispose of the client object
                client.Dispose();
            }

            Console.ReadLine();
        }
    }
}
