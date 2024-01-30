# SoporNu

En .NET API-klient för [Sopor.nu](https://www.sopor.nu) Hitta återvinning.

## Användning

1. Lägg NuGet [SoporNu](https://www.nuget.org/packages/SoporNu) till ditt projekt:

    ```
    dotnet add package SoporNu --prerelease
    ```

2. Skapa en instans av `SoporApiClient`, och hämta ÅVS från Avfallshubben. T.ex.:

    ```csharp
    var client = new SoporApiClient();

    var avs = await client.GetAllAvs();
    ```

Om du använder Microsoft.Extensions.DependencyInjection, se [SoporNu.Extensions.Microsoft.DependencyInjection](https://github.com/logikfabrik/SoporNu/blob/master/src/SoporNu.Extensions.Microsoft.DependencyInjection).

## Hur bidra

SoporNu är öppen källkod (MIT), och du får gärna bidra!

Om du har en buggrapport, en funktionsbegäran, eller ett förslag, öppna ett nytt ärende. För att skicka in en patch, var vänlig skapa en PR.