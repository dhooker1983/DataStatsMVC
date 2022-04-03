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
        private readonly string _apiKey = "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";
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
