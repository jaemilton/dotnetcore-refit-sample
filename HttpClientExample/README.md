# HttpClientExample

A .NET 8 console application demonstrating the use of [Refit](https://github.com/reactiveui/refit) for type-safe REST API integration, including models, endpoints, and serialization customization.

## Features

- **Type-safe API calls** using Refit interfaces
- **Model classes** for structured JSON responses
- **Custom serialization** with `System.Text.Json`
- **Examples for multiple APIs** (e.g., My-IP, ReqRes)

## Project Structure

- `Program.cs` – Entry point; demonstrates API usage and JSON serialization.
- `integrations/` – Contains API endpoint definitions and Refit interfaces.
- `models/` – Contains C# models for deserializing JSON responses.

## Example APIs

- **My-IP API**: Fetches your public IP and related geo/network info.
- **ReqRes Users API**: Example endpoints for user data.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Refit NuGet package](https://www.nuget.org/packages/Refit)

### Build and Run

https://beeceptor.com/crud-api/ ==> free CRUD  API endpoint for testing
