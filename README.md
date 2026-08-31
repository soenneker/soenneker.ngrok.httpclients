[![](https://img.shields.io/nuget/v/soenneker.ngrok.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ngrok.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ngrok.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.ngrok.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.ngrok.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.ngrok.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.ngrok.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.ngrok.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.ngrok.HttpClients

Provides a cached `HttpClient` with ngrok API authentication and version headers.

## Installation

```bash
dotnet add package Soenneker.ngrok.HttpClients
```

## Configuration

```json
{
  "ngrok": {
    "ApiKey": "your-api-key"
  }
}
```

The client sends `Authorization: Bearer {token}` and `ngrok-version: 2`. `ngrok:ClientBaseUrl`, `ngrok:AuthHeaderName`, `ngrok:AuthHeaderValueTemplate`, and `ngrok:ApiVersion` can override those defaults.

## Usage

```csharp
using Soenneker.ngrok.HttpClients.Abstract;
using Soenneker.ngrok.HttpClients.Registrars;

services.AddngrokOpenApiHttpClientAsSingleton();

IngrokOpenApiHttpClient ngrok = serviceProvider
    .GetRequiredService<IngrokOpenApiHttpClient>();

HttpClient client = await ngrok.Get(cancellationToken);
```

Do not dispose the returned `HttpClient`; the registered provider owns it and removes it from the cache when disposed.
