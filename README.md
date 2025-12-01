# Azure AI Chat API (ASP.NET Core 8)

A minimal, production-ready ASP.NET Core 8 Web API that integrates with **Azure OpenAI** to provide a `/chat` endpoint.  
If Azure credentials are not configured, the API automatically falls back to a safe **local dummy AI mode**.

This project is ideal as a starter template for AI-driven backend services or as a clean demonstration of Azure OpenAI integration during recruitment.

---

## 🚀 Features

### ✔ Minimal API (ASP.NET Core 8)
Built using the lightweight minimal API approach.

### ✔ `/chat` endpoint with Azure OpenAI support
Sends user messages to an Azure-hosted LLM deployment  
(e.g., `gpt-4o-mini`, `gpt-4o`, `gpt-35-turbo`).

### ✔ Automatic “dummy mode”
If Azure credentials are missing in `appsettings.json`, the API returns safe local mock responses:


{
  "reply": "(local dummy): Received: \"hello\". Configure AzureAI to enable real model responses."
}
Useful for:

running the app without Azure access

demos & interviews

local development

✔ Swagger UI included
Interactive API documentation at:

https://localhost:{port}/swagger
✔ Safe configuration (no secrets in repository)
appsettings.example.json is provided

real appsettings.json is ignored via .gitignore

users insert their own Azure keys locally

✔ Additional sample endpoint
The default /weatherforecast endpoint is included for testing.

📁 Project Structure

AzureAIChatApi/
│── Program.cs
│── appsettings.json          # ignored (local secrets)
│── appsettings.example.json  # template for users
│── AzureAIChatApi.http       # REST client examples
│── .gitignore
└── README.md
🔧 Requirements
.NET 8 SDK

Azure OpenAI resource (optional — required only for real AI responses)

🛠 Configuration
1. Copy the example config

cp appsettings.example.json appsettings.json
2. Insert your Azure OpenAI values
Example:

"AzureAI": {
  "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
  "Key": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}
3. Run the API

dotnet run

💬 Using the /chat endpoint
Request
bash
Skopiuj kod
POST /chat
Content-Type: application/json

{
  "message": "Hello AI!"
}
Response (with Azure OpenAI)

{
  "reply": "Cześć! Jak mogę Ci pomóc?"
}
Response (dummy mode)

{
  "reply": "(local dummy): Received: \"Hello AI!\". Configure AzureAI to enable real model responses."
}
🧠 Technologies Used
ASP.NET Core 8 Minimal API

Azure OpenAI (Azure.AI.OpenAI NuGet)

Swagger / OpenAPI

Modern C# 12 minimal hosting model

📌 Purpose of the Project
This repository serves as a clean, secure, and professional example of:

integrating Azure OpenAI with .NET

building minimal APIs

implementing safe secret management

designing a developer-friendly API with Swagger UI

preparing a portfolio-ready project for recruitment

Perfect for showing engineering quality, cloud understanding, and AI integration skills.
