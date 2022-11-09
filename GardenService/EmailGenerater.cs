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
    public class EmailGenerator
    {
        //send an email from the application to an email using SMTP
        public static void SendLoginDetails(string name, string email, string userName, string password)
        {
            try
            {
                {
                    SmtpClient smtpCilent = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587, //port of the email server
                        Credentials = new NetworkCredential("alessandraribeiro090692@gmail.com", "ocztrutwrqbcatqd"),
                        EnableSsl = true, //secure shell to be able to send it 
                    };



                    smtpCilent.Send("alessandraribeiro090692@gmail.com", email, "Garden Group login details", $"Hi {name}, We are really happy to have you on the GARDEN GROUP team!\n"  +
                       "\nHere is your login details:\n" + $"USERNAME: {userName} \nPASSWORD: {password} \n" +
                       "\n We look forward to learning and growing alongside you for the years to come!\n" +
                       "                Garden Group Team");
                    smtpCilent.Dispose();



                }
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

