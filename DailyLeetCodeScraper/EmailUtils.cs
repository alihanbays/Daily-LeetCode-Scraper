using System.Text;
using DailyLeetCodeScraper.Modal;
using Smtp2Go.Api;
using Smtp2Go.Api.Models.Emails;

namespace DailyLeetCodeScraper;

public class EmailUtils { 
    private static readonly HttpClient client = new HttpClient();
    private const string LogicAppUrl = "https://prod-05.centralindia.logic.azure.com:443/workflows/2a35f2efd3b6409499c109bb4f224f91/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=oyHMLnHT7SuLlnp26fJBVV4yihlq3_ATBLrcbFDFJM8";
    public async Task SendMailAsync(Question dailyQuestion)
    {
    var adaptiveCard = new
    {
        type = "message",
        attachments = new[]
        {
            new
            {
                contentType = "application/vnd.microsoft.card.adaptive",
                contentUrl = (string)null,
                content = new
                {
                    type = "AdaptiveCard",
                    version = "1.3", // Use a more recent version
                    body = new object[]
                    {
                        new
                        {
                            type = "TextBlock",
                            size = "Large",
                            weight = "Bolder",
                            text = "Daily LeetCode Challenge",
                            color = "Primary"
                        },
                        new
                        {
                            type = "TextBlock",
                            size = "Medium",
                            weight = "Bolder",
                            text = dailyQuestion.Title,
                            color = "Accent"
                        },
                        new
                        {
                            type = "TextBlock",
                            text = "Problem Description:",
                            weight = "Bolder"
                        },
                        new
                        {
                            type = "TextBlock",
                            text = dailyQuestion.Body,
                            wrap = true
                        },
                        new
                        {
                            type = "TextBlock",
                            text = "Good luck and happy coding!",
                            weight = "Bolder"
                        }
                    },
                    }
                }
            }
        };
        
        var content = new StringContent(
            System.Text.Json.JsonSerializer.Serialize(adaptiveCard),
            Encoding.UTF8,
            "application/json");
        var response = await client.PostAsync(LogicAppUrl, content);
        
        // var service = new Smtp2GoApiService("api-0A99721C17324EB49F2119D3D74C56FA");
        //
        // var message = new EmailMessage
        // {
        //     Sender = "alihan.baysal@intimetec.com",
        //     Subject = $"Daily LeetCode Challenge: {dailyQuestion.Title}",
        //     BodyHtml = FormatEmailBody(dailyQuestion),
        //     BodyText = FormatPlainTextBody(dailyQuestion),
        // };
        //
        // message.AddToAddress("8f8738d3.intimetec.com@in.teams.ms");
        //
        // try
        // {
        //     var response = await service.SendEmail(message);
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Failed to send email: {ex.Message}");
        // }
    }
    
//     private string FormatEmailBody(Question dailyQuestion)
//     {
//         return $"""
//                 
//                     <html>
//                     <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
//                         <h1 style='color: #4a4a4a;'>Daily LeetCode Challenge</h1>
//                         <h2 style='color: #0066cc;'>{dailyQuestion.Title}</h2>
//                         <div style='background-color: #f9f9f9; padding: 15px; border-radius: 5px;'>
//                             <h3>Problem Description:</h3>
//                             <p>{dailyQuestion.Body}</p>
//                         </div>
//                         <p>Good luck and happy coding!</p>
//                         <p>Visit <a href='https://leetcode.com/problemset/all/'>LeetCode</a> for more challenges.</p>
//                     </body>
//                     </html>
//                 """;
//     }
//
//     private string FormatPlainTextBody(Question dailyQuestion)
//     {
//         return $"""
//
//                 Daily LeetCode Challenge
//
//                 {dailyQuestion.Title}
//
//                 Problem Description:
//                 {dailyQuestion.Body}
//
//                 Good luck and happy coding!
//
//                 Visit https://leetcode.com/problemset/all/ for more challenges.
//                 """;
//     }
}