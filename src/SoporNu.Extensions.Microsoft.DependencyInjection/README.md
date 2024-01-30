# SoporNu.Extensions.Microsoft.DependencyInjection

DI-tillägg för Microsoft.Extensions.DependencyInjection. [SoporNu](https://github.com/logikfabrik/SoporNu) är en .NET API-klient för [Sopor.nu](https://www.sopor.nu) Hitta återvinning.

## Användning

1. Lägg NuGet [SoporNu.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/SoporNu.Extensions.Microsoft.DependencyInjection) till ditt projekt:

    ```
    dotnet add package SoporNu.Extensions.Microsoft.DependencyInjection --prerelease
    ```

2. Vid start-up av din app, lägg till SoporNu:

    ```csharp
    builder.Services.AddSoporApiClient();
    ```

3. Ta ett beroende på `ISoporApiClient`, och hämta ÅVS från Avfallshubben. T.ex.:

    ```csharp
    public class AvsService
    {
        private readonly ISoporApiClient _client;

        public AvsService(ISoporApiClient client)
        {
            _client = client;
        }
    }
    ```

## Hur bidra

SoporNu är öppen källkod (MIT), och du får gärna bidra!

Om du har en buggrapport, en funktionsbegäran, eller ett förslag, öppna ett nytt ärende. För att skicka in en patch, var vänlig skapa en PR.