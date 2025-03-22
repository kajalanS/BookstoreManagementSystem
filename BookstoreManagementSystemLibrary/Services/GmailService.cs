using BookstoreManagementSystemLibrary.Helpers;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace BookstoreManagementSystemLibrary.Services
{
  /// <summary>
  /// Provides static methods for sending emails using Gmail with OAuth2 and refresh token support.
  /// </summary>
  public static class GmailService
  {
    private static string? clientId;
    private static string? clientSecret;
    private static string? userEmail;
    private static string? refreshToken;
    private static readonly string[] Scopes = { "https://mail.google.com/" };

    /// <summary>
    /// Initializes the GmailService using provided credentials.
    /// </summary>
    /// <param name="clientId">Your Google client ID.</param>
    /// <param name="clientSecret">Your Google client secret.</param>
    /// <param name="userEmail">The Gmail address to send from.</param>
    /// <param name="refreshToken">The refresh token to use for authentication.</param>
    public static void Initialize(string clientId, string clientSecret, string userEmail, string refreshToken)
    {
      GmailService.clientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
      GmailService.clientSecret = clientSecret ?? throw new ArgumentNullException(nameof(clientSecret));
      GmailService.userEmail = userEmail ?? throw new ArgumentNullException(nameof(userEmail));
      GmailService.refreshToken = refreshToken ?? throw new ArgumentNullException(nameof(refreshToken));
    }

    /// <summary>
    /// Sends an email with plain text body using Gmail and OAuth2 authentication.
    /// </summary>
    public static async Task SendHtmlEmailAsync(this string toEmail, string subject, string bodyText)
    {
      await SendEmailInternalAsync(toEmail, subject, bodyText, "plain", null);
    }

    /// <summary>
    /// Sends an email with HTML content read from a file. The file should be accessible in the project scope.
    /// </summary>
    /// <param name="toEmail">Recipient's email address.</param>
    /// <param name="subject">Email subject.</param>
    /// <param name="htmlFilePath">Path to the HTML file containing the email content.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static async Task SendHtmlEmailAsync(this string toEmail, string subject, string htmlFilePath, Dictionary<string, string> dataMapper)
    {
      if (!File.Exists(htmlFilePath))
        throw new FileNotFoundException("HTML file not found", htmlFilePath);

      string htmlContent = await File.ReadAllTextAsync(htmlFilePath);

      foreach (var dataItem in dataMapper)
      {
        htmlContent = htmlContent.Replace(dataItem.Key, dataItem.Value);
      }

      await SendEmailInternalAsync(toEmail, subject, htmlContent, "html", null);
    }

    /// <summary>
    /// Sends an email with HTML content loaded from an embedded resource and performs placeholder replacements based on the provided dictionary.
    /// </summary>
    /// <param name="toEmail">Recipient's email address.</param>
    /// <param name="subject">Email subject.</param>
    /// <param name="templateType">The type of email template to use.</param>
    /// <param name="dataMapper">A dictionary containing placeholders and their replacement values.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static async Task SendHtmlEmailAsync(this string toEmail, string subject, EmailTemplateType templateType, Dictionary<EmailTemplatePlaceHolder, object> dataMapper)
    {
      // Load the HTML content from the embedded resource.
      string htmlContent = templateType.ProcessTemplate(dataMapper);

      // Send the email (assuming SendEmailInternalAsync is implemented in your GmailService).
      await SendEmailInternalAsync(toEmail, subject, htmlContent, "html", null);
    }

    /// <summary>
    /// Internal method to send email. Optionally allows further customization of the MimeMessage.
    /// </summary>
    private static async Task SendEmailInternalAsync(string toEmail, string subject, string bodyContent, string mimeType, Action<MimeMessage>? additionalSetup)
    {
      if (string.IsNullOrEmpty(clientId) ||
          string.IsNullOrEmpty(clientSecret) ||
          string.IsNullOrEmpty(userEmail) ||
          string.IsNullOrEmpty(refreshToken))
      {
        throw new InvalidOperationException("GmailService is not initialized. Call Initialize() first.");
      }

      // Create a token response with the refresh token.
      var tokenResponse = new TokenResponse { RefreshToken = refreshToken };

      // Create the authorization flow.
      var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
      {
        ClientSecrets = new ClientSecrets
        {
          ClientId = clientId,
          ClientSecret = clientSecret
        },
        Scopes = Scopes
      });

      // Create a UserCredential and refresh the access token.
      var credential = new UserCredential(flow, "user", tokenResponse);
      bool success = await credential.RefreshTokenAsync(CancellationToken.None);
      if (!success)
      {
        throw new Exception("Failed to refresh access token.");
      }
      string accessToken = credential.Token.AccessToken;

      // Build the email message.
      var message = new MimeMessage();
      message.From.Add(new MailboxAddress("Sender", userEmail));
      message.To.Add(new MailboxAddress("", toEmail));
      message.Subject = subject;

      // Create a TextPart with the specified mime type ("plain" or "html").
      message.Body = new TextPart(mimeType) { Text = bodyContent };

      // Apply additional customizations if provided.
      additionalSetup?.Invoke(message);

      // Send the email using MailKit.
      using var client = new SmtpClient();

      // For demonstration purposes only. In production, validate SSL certificates.
      //client.ServerCertificateValidationCallback = (s, c, h, e) => true;

      await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
      var oauth2 = new SaslMechanismOAuth2(userEmail, accessToken);
      await client.AuthenticateAsync(oauth2);

      await client.SendAsync(message);
      await client.DisconnectAsync(true);
    }
  }
}
