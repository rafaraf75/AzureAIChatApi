# Azure AI Chat API (ASP.NET Core 8)

A minimal and production-style ASP.NET Core 8 Web API with an optional Azure OpenAI integration and a built-in Razor Pages UI.  
The `/chat` endpoint works with real Azure OpenAI deployments — and automatically falls back to a safe **local dummy mode** when no Azure credentials are provided.

Perfect as a **portfolio project**, **coding sample**, or a **starter template** for AI-powered backend services.

---

## 🚀 Features

### ✔ Minimal API (ASP.NET Core 8)

Lightweight modern architecture – no controllers, clean routing, easy to extend.

### ✔ `/chat` endpoint with Azure OpenAI support

Works with any Azure OpenAI chat model, for example:

- `gpt-4o-mini`
- `gpt-4o`
- `gpt-35-turbo`

### ✔ Automatic “dummy mode” (no Azure required)

If Azure credentials are missing, the API switches to a local mock mode:

```json
{
  "reply": "(local dummy): Received: 'hello'. Configure AzureAI to enable real model responses."
}
```
This allows:

running without Azure access

demos during interviews

safe local development

letting recruiters run the project instantly

✔ Built-in Razor Pages Chat UI
A lightweight, modern UI for interacting with the /chat endpoint:

HTML + CSS + vanilla JS

clean, “enterprise-like” card layout

Enter to send, Ctrl/Cmd + Enter for newline

works in both Azure and dummy modes

Open it at:

```text
https://localhost:{port}/chat
```
✔ Swagger UI included
Interactive API docs available at:

```text
https://localhost:{port}/swagger
```
✔ Safe configuration (no secrets in repo)
appsettings.example.json shows required structure

real appsettings.json is ignored via .gitignore

Azure keys stay on your machine only

✔ Additional sample endpoint
Default ASP.NET Core template endpoint:

```text
/weatherforecast
```
##Screenshot
<img width="1829" height="1167" alt="image" src="https://github.com/user-attachments/assets/cf838878-e044-4886-804d-f613b81f930b" />

📁 Project Structure
```text
AzureAIChatApi/
 ├── Program.cs
 ├── Pages/                     # Razor Pages UI
 │     ├── Chat.cshtml          # Chat console UI
 │     └── _Layout.cshtml       # Shared layout
 ├── appsettings.json           # local-only (ignored)
 ├── appsettings.example.json   # sample config
 ├── AzureAIChatApi.http        # REST client samples
 ├── .gitignore
 └── README.md
```
🔧 Requirements
.NET 8 SDK

(Optional) Azure OpenAI resource for real model responses

🛠 Configuration
1. Create a local config
```bash
cp appsettings.example.json appsettings.json
```
2. Insert your Azure OpenAI values
```json
"AzureAI": {
  "Endpoint": "https://YOUR-RESOURCE.openai.azure.com/",
  "Key": "YOUR-KEY",
  "DeploymentName": "gpt-4o-mini"
}
```
3. Run the API
```bash
dotnet run
```
💬 Using the /chat endpoint
Request
```http
POST /chat
Content-Type: application/json
```
```json
{
  "message": "Hello AI!"
}
```
Response (Azure OpenAI enabled)
```json
{
  "reply": "Cześć! Jak mogę Ci pomóc?"
}
```
Response (dummy mode)
```json
{
  "reply": "(local dummy): Received: 'Hello AI!'. Configure AzureAI to enable real model responses."
}
```
🧠 Technologies Used
ASP.NET Core 8 (Minimal API)

Razor Pages (UI)

Azure.AI.OpenAI SDK

Swagger / OpenAPI

C# / .NET 8

📌 Purpose of This Project
This repository demonstrates:

clean Azure OpenAI integration

secure configuration & secret management

modern .NET 8 minimal API patterns

a complete pipeline: API → AI model → UI

dummy fallback for easy demos

portfolio-grade project structure

Recommended for:

Azure AI / LLM Developer roles

AI Integration / AI Engineer roles

.NET + AI job interviews

Portfolio and GitHub presence

Prototyping conversational AI backends

🎯 Summary
This template gives you a ready-to-use AI backend with both local and Azure-powered modes, a clean web UI, and a professional architecture suitable for real-world work or recruitment.
