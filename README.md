Azure AI Chat API (ASP.NET Core)

This project is a minimal ASP.NET Core Web API that connects to Azure OpenAI (or works in local “dummy mode” if no keys are configured).
It exposes a simple /chat endpoint you can use to send messages to an LLM model.

🚀 Features

Minimal API (ASP.NET Core 8)

/chat endpoint with Azure OpenAI support

Automatic fallback to “local dummy AI” if no Azure credentials are provided

/weatherforecast example endpoint (default template)

Swagger UI included

Safe configuration using appsettings.example.json

.gitignore included to avoid leaking secrets

📦 Requirements

.NET 8 SDK

Azure OpenAI (optional — required for real AI responses)

Valid model deployment (e.g. gpt-4o-mini, gpt-4o, etc.)

🔧 Configuration

Copy the example configuration:

appsettings.example.json  →  appsettings.json


Fill in your Azure credentials:

{
  "AzureAI": {
    "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
    "Key": "YOUR_API_KEY",
    "DeploymentName": "YOUR_MODEL"
  }
}


If you leave these fields empty, API will run in dummy local mode.

▶️ Running the API
dotnet run


Then open Swagger:

https://localhost:7003/swagger

💬 Chat Endpoint
Request

POST /chat

{
  "message": "Hello!"
}

Response (Azure mode)
{
  "reply": "Hello, how can I help you today?"
}

Response (local dummy mode)
{
  "reply": "(local dummy): Otrzymałem: \"Hello!\". Skonfiguruj AzureAI w appsettings.json."
}

📁 Project Structure
/AzureAIChatApi
  Program.cs
  appsettings.json (ignored)
  appsettings.example.json
  .gitignore
  AzureAIChatApi.http
  README.md

📜 License

If you find this useful, leave a ⭐ on the repository!
