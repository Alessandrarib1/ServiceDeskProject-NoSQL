using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace GardenService
{
    public class EmailGenerater
    {
        //send an email from the application to an email using SMTP
        public static void SendLoginDetailsThroughSMTP(string email, string userName, string password)
        {
            try
            {
                //make an conf file
                var builder = new ConfigurationBuilder()
               .AddJsonFile("EmailCredential.json");
                var config = builder.Build();



                SmtpClient smtpCilent = new SmtpClient(config["Smtp:Host"])
                {
                    Port = int.Parse(config["Smtp:Port"]), //port of the email server
                    Credentials = new NetworkCredential(config["Smtp:Email"], config["Smtp:Password"]),
                    EnableSsl = true, //secure shell to be able to send it 
                };



                smtpCilent.Send(config["Smtp:Email"], email, "YourLoginDetails", $"Here are your new login credential username: {userName} password: {password}");
                smtpCilent.Dispose();



            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Unable to find the email config file");
            }
            catch (SmtpFailedRecipientsException)
            {
                throw new SmtpFailedRecipientsException($"Unable to send email to {email}");
            }
        }
    }
}

