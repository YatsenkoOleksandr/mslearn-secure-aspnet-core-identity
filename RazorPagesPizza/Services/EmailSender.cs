using Microsoft.AspNetCore.Identity.UI.Services;

namespace RazorPagesPizza.Services;

/// <summary>
/// Email sender which logs sent email
/// </summary>
public class EmailSender : IEmailSender
{
    private readonly ILogger<EmailSender> _logger;

    public EmailSender(ILogger<EmailSender> logger)
    {
        _logger = logger;
    }

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        _logger.LogInformation("Email Confirmation Message:");
        _logger.LogInformation("--------------------------");
        _logger.LogInformation("TO: {email}", email);
        _logger.LogInformation("SUBJECT: {subject}", subject);
        _logger.LogInformation("CONTENTS: {htmlMessage}", htmlMessage);
        _logger.LogInformation("...");

        return Task.CompletedTask;
    }
}
