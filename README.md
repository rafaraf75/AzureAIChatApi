# Azure AI Chat API (ASP.NET Core 8)

A minimal ASP.NET Core 8 Web API that integrates with **Azure OpenAI** to provide a `/chat` endpoint.  
If Azure credentials are not configured, the API automatically falls back to a safe **local dummy AI mode**.

This project is ideal as a starter template for AI-driven backend services or as part of a **recruitment portfolio**.

---

## 🚀 Features

### ✔ Minimal API (ASP.NET Core 8)
Lightweight architecture with no controllers — clean, modern, and easy to extend.

### ✔ `/chat` endpoint with Azure OpenAI support
Sends user messages to an Azure-hosted LLM deployment such as:

- `gpt-4o-mini`
- `gpt-4o`
- `gpt-35-turbo`

### ✔ Automatic “dummy mode”
If Azure credentials are missing, the API returns safe mocked responses:

```json
{
  "reply": "(local dummy): Received: 'hello'. Configure AzureAI to enable real model responses."
}
Useful for:

running without Azure access

demos / interviews

local development

✔ Swagger UI included
Interactive API docs available at:

bash
Skopiuj kod
https://localhost:{port}/swagger
✔ Safe configuration (no secrets in repo)
appsettings.example.json is included

real appsettings.json is ignored via .gitignore

users insert their own Azure keys locally

✔ Additional sample endpoint
A classic ASP.NET template endpoint:

bash
Skopiuj kod
/weatherforecast
📁 Project Structure
pgsql
Skopiuj kod
AzureAIChatApi/
 ├── Program.cs
 ├── appsettings.json              # ignored (local secrets)
 ├── appsettings.example.json      # template for users
 ├── AzureAIChatApi.http           # REST client samples
 ├── .gitignore
 └── README.md
🔧 Requirements
.NET 8 SDK

Azure OpenAI resource (optional — required only for real AI responses)

🛠 Configuration
1. Copy the example config
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
json
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

clean and secure integration with Azure OpenAI

modern minimal API architecture

safe secret handling using .gitignore

developer-friendly design with Swagger

Perfect for:

✔ recruitment tasks

✔ portfolio projects

✔ boilerplate for AI-enabled backend services
