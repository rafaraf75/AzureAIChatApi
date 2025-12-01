# Azure AI Chat API (ASP.NET Core 8)

A minimal ASP.NET Core 8 Web API that integrates with **Azure OpenAI** to provide a `/chat` endpoint.  
If Azure credentials are not configured, the API automatically falls back to a safe **local dummy AI mode**.

This project is ideal as a starter template for AI-driven backend services or for demonstrating Azure OpenAI integration in recruitment processes.

---

## 🚀 Features

### ✔ Minimal API (ASP.NET Core 8)
Built entirely using the lightweight minimal API style.

### ✔ `/chat` endpoint with Azure OpenAI support
Sends user messages to an Azure-hosted LLM deployment  
(e.g., `gpt-4o-mini`, `gpt-4o`, `gpt-35-turbo`).

### ✔ Automatic “dummy mode”
If Azure credentials are missing in *appsettings.json*, the API returns safe mock responses:


{
  "reply": "(local dummy): Received: \"hello\". Configure AzureAI to enable real model responses."
}

Useful for:

running the app without Azure access

demos

local development

✔ Swagger UI included
Interactive API documentation available immediately at:

https://localhost:<port>/swagger
✔ Safe configuration (no secrets in repo)
appsettings.example.json is provided

actual appsettings.json is secured via .gitignore

users must insert their own Azure keys locally

✔ Additional sample endpoint
A classic /weatherforecast endpoint from the ASP.NET template.

📁 Project Structure

AzureAIChatApi/
 ├── Program.cs
 ├── appsettings.json (ignored)
 ├── appsettings.example.json
 ├── AzureAIChatApi.http
 ├── .gitignore
 └── README.md
🔧 Requirements
.NET 8 SDK

Azure OpenAI resource (optional; needed for real AI responses)

🛠 Configuration
1. Copy the example config

cp appsettings.example.json appsettings.json

2. Insert your Azure OpenAI values

"AzureAI": {
  "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
  "Key": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}

3. Run the API

dotnet run

💬 Using the /chat endpoint
Request:

POST /chat
Content-Type: application/json

{
  "message": "Hello AI!"
}
Response (with Azure OpenAI):

{
  "reply": "Cześć! Jak mogę Ci pomóc?"
}
Response (dummy mode):

{
  "reply": "(local dummy): Received: \"Hello AI!\". Configure AzureAI to enable real model responses."
}

🧠 Technologies Used
ASP.NET Core 8 Minimal API

Azure OpenAI (via Azure.AI.OpenAI NuGet package)

Swagger / OpenAPI

📌 Purpose of the Project
This repository serves as a clean, secure, and well-structured example of:

integrating Azure OpenAI with .NET

building minimal APIs

safe secret management

creating a developer-friendly API with documentation

Perfect for recruitment, portfolios, or as a boilerplate for AI backend development.

