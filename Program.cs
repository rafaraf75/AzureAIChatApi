using System.Collections.Generic;
using Azure;
using Azure.AI.OpenAI;
using OpenAI.Chat;

var builder = WebApplication.CreateBuilder(args);

// Razor Pages (widoki)
builder.Services.AddRazorPages();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger tylko w dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// statyczne pliki (css/js, layout itp.)
app.UseStaticFiles();

app.UseRouting();

// ===== RAZOR PAGES (Chat.cshtml) =====
app.MapRazorPages();

// ===== STARY ENDPOINT /weatherforecast – zostawiamy =====
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild",
    "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast(
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

// ===== KONFIGURACJA AZURE AI Z appsettings.json =====
var azureSection = app.Configuration.GetSection("AzureAI");
var endpoint = azureSection["Endpoint"];
var apiKey = azureSection["Key"];
var deploymentName = azureSection["DeploymentName"];

ChatClient? chatClient = null;

if (!string.IsNullOrWhiteSpace(endpoint) &&
    !string.IsNullOrWhiteSpace(apiKey) &&
    !string.IsNullOrWhiteSpace(deploymentName))
{
    var credential = new AzureKeyCredential(apiKey);
    var azureClient = new AzureOpenAIClient(new Uri(endpoint), credential);
    chatClient = azureClient.GetChatClient(deploymentName);
}

// ===== NOWY ENDPOINT /chat =====
app.MapPost("/chat", async Task<IResult> (ChatRequest request) =>
{
    if (chatClient is null)
    {
        var dummy = $"(local dummy): Otrzyma³em: \"{request.Message}\". " +
                    "Skonfiguruj AzureAI w appsettings.json, ¿eby gadaæ z prawdziwym modelem.";
        return Results.Ok(new { reply = dummy });
    }

    var messages = new List<ChatMessage>
    {
        new SystemChatMessage("You are a helpful assistant that answers in Polish."),
        new UserChatMessage(request.Message)
    };

    ChatCompletion completion = await chatClient.CompleteChatAsync(messages);
    var replyText = completion.Content[0].Text;

    return Results.Ok(new { reply = replyText });
})
.WithName("Chat")
.WithOpenApi();

app.Run();

// ===== TYPY POMOCNICZE =====
internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

internal record ChatRequest(string Message);