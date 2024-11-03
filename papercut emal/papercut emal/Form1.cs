using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using papercut_emal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

    namespace EmailDemo
    {
        internal class Program
        {
            static async Task Main(string[] args)
            {
                var sender = new SmtpSender(() => new SmtpClient(host: "localhost")
                {
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Port = 25
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