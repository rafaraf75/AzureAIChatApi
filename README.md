# Azure AI Chat API (ASP.NET Core 8)

A minimal ASP.NET Core 8 Web API that integrates with **Azure OpenAI** to provide a `/chat` endpoint.  
If Azure credentials are not configured, the API automatically falls back to a safe **local dummy AI mode**.

This project is ideal as a starter template for AI-driven backend services or as part of a **recruitment portfolio**.

---

## 🚀 Features

### ✔ Minimal API (ASP.NET Core 8)
Lightweight and clean architecture with no controllers.

### ✔ `/chat` endpoint with Azure OpenAI support
Sends user messages to an Azure-hosted LLM deployment such as:
- `gpt-4o-mini`
- `gpt-4o`
- `gpt-35-turbo`

### ✔ Automatic "dummy mode"
When Azure credentials are missing, the API returns a safe mocked response:

```json
{
  "reply": "(local dummy): Received: 'hello'. Configure AzureAI to enable real model responses."
}
Useful for:

running the app without Azure access

demos & interviews

local development

✔ Swagger UI included
Interactive documentation available at:

bash
Skopiuj kod
https://localhost:{port}/swagger
✔ Safe configuration (no secrets committed)
appsettings.example.json included

real appsettings.json is ignored via .gitignore

users add their own Azure keys locally

✔ Additional sample endpoint
Classic /weatherforecast endpoint from the ASP.NET template.

📁 Project Structure
pgsql
Skopiuj kod
AzureAIChatApi/
├── Program.cs
├── appsettings.json            # ignored (local secrets)
├── appsettings.example.json    # template
├── AzureAIChatApi.http         # REST client samples
├── .gitignore
└── README.md
🔧 Requirements
.NET 8 SDK

Azure OpenAI resource (optional — required only for real model responses)

🛠 Configuration
1. Copy example configuration
bash
Skopiuj kod
cp appsettings.example.json appsettings.json
2. Insert your Azure OpenAI values
json
Skopiuj kod
"AzureAI": {
  "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
  "Key": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}
3. Run the API
bash
Skopiuj kod
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
Response (Azure OpenAI enabled)
json
Skopiuj kod
{
  "reply": "Cześć! Jak mogę Ci pomóc?"
}
Response (dummy mode)
json
Skopiuj kod
{
  "reply": "(local dummy): Received: 'Hello AI!'. Configure AzureAI to enable real model responses."
}
🧠 Technologies Used
ASP.NET Core 8 Minimal API

Azure OpenAI (Azure.AI.OpenAI SDK)

Swagger / OpenAPI

📌 Purpose of the Project
This repository demonstrates:

secure and clean integration with Azure OpenAI

modern minimal API architecture

safe secret handling with .gitignore

developer-friendly design with Swagger documentation

Perfect for:

recruitment tasks

portfolio projects

AI backend boilerplates
