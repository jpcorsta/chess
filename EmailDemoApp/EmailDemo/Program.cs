using FluentEmail.Core;
using FluentEmail.Smtp;

using System.Globalization;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new SmtpSender(() => new SmtpClient(host: "localhost")
            {
                EnableSsl = false,
                DeliveryMethod=SmtpDeliveryMethod.Network,
                Port=25
                //DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                //PickupDirectoryLocation = @"C:\Demos"
            });

            Email.DefaultSender = sender;

            var email = await Email
                .From(emailAddress: "tim@timco.com")
                .To(emailAddress: "test@test.com", name: "Sue")
                .Subject(subject: "Thanks!")
                .Body(body: "Thanks for buying our product.")
                .SendAsync();
            
        }
    }
}
