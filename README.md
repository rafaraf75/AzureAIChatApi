✅ Azure AI Chat API (ASP.NET Core 8)

A minimal, production-ready ASP.NET Core 8 Web API that integrates with Azure OpenAI to provide a /chat endpoint.

If Azure credentials are missing, the API automatically switches to a safe local dummy mode, making the project runnable anywhere — even without an Azure account.

Perfect for recruiters, portfolios, or as a starter template for AI-powered backend services.

🚀 Features
✔ Minimal API (ASP.NET Core 8)

Lightweight, modern API style with minimal overhead.

✔ /chat endpoint with Azure OpenAI support

Sends user messages to an LLM deployed in Azure.
Supports deployments such as:

gpt-4o-mini

gpt-4o

gpt-35-turbo

✔ Automatic “dummy mode”

If no Azure credentials are found in appsettings.json, the API returns mock responses:

{ "reply": "(local dummy): Received: \"hello\". Configure AzureAI to enable real model responses." }


Useful for:

local development

running without Azure access

demos

✔ Swagger UI included

Interactive API documentation:

https://localhost:{port}/swagger

✔ Safe configuration (no secrets in repo)

appsettings.example.json included

real appsettings.json ignored through .gitignore

users insert their own Azure keys locally

✔ Additional sample endpoint

The default ASP.NET template /weatherforecast endpoint is included.

📁 Project Structure
AzureAIChatApi/
├── Program.cs
├── appsettings.json            # ignored (local secrets)
├── appsettings.example.json    # template for users
├── AzureAIChatApi.http         # REST client samples
├── .gitignore
└── README.md

🔧 Requirements

.NET 8 SDK

Azure OpenAI resource (optional — required only for real model responses)

🛠 Configuration
1️⃣ Copy the example config
cp appsettings.example.json appsettings.json

2️⃣ Insert Azure OpenAI values
"AzureAI": {
  "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
  "Key": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}

3️⃣ Run the API
dotnet run

💬 Using the /chat endpoint
Request
POST /chat
Content-Type: application/json

{
  "message": "Hello AI!"
}

Response (Azure OpenAI enabled)
{
  "reply": "Cześć! Jak mogę Ci pomóc?"
}

Response (dummy mode)
{
  "reply": "(local dummy): Received: \"Hello AI!\". Configure AzureAI to enable real model responses."
}

🧠 Technologies Used

ASP.NET Core 8 Minimal API

Azure OpenAI (Azure.AI.OpenAI NuGet package)

Swagger / OpenAPI

📌 Purpose of the Project

This repository is designed to be a clean, secure, and well-structured example of:

integrating Azure OpenAI with .NET

building minimal APIs

safe secret management

creating a developer-friendly API with documentation

Suitable for:

recruitment

portfolio projects

AI backend boilerplates
