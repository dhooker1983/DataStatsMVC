using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace DataStatsMVC.Areas.Identity
{
    public class EmailSender : IEmailSender
    {
        //TODO Inject config options for the SendGrid API Key
        private readonly string _apiKey = "";
        private readonly string _fromName ="DataStats";
        private readonly string _fromEmail = "dhooker@sky.com";

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(_apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_fromEmail, _fromName),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(email);

            msg.SetClickTracking(false, false);

            var result = await client.SendEmailAsync(msg);

        }

    }
}
