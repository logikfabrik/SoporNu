# SoporNu.Extensions.Microsoft.DependencyInjection

DI-till�gg f�r Microsoft.Extensions.DependencyInjection. [SoporNu](https://github.com/logikfabrik/SoporNu) �r en .NET API-klient f�r [Sopor.nu](https://www.sopor.nu) Hitta �tervinning.

## Anv�ndning

1. L�gg NuGet [SoporNu.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/SoporNu.Extensions.Microsoft.DependencyInjection) till ditt projekt:

    ```
    dotnet add package SoporNu.Extensions.Microsoft.DependencyInjection --prerelease
    ```

2. Vid start-up av din app, l�gg till SoporNu:

    ```csharp
    builder.Services.AddSoporApiClient();
    ```

3. Ta ett beroende p� `ISoporApiClient`, och h�mta �VS fr�n Avfallshubben. T.ex.:

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

SoporNu �r �ppen k�llkod (MIT), och du f�r g�rna bidra!

Om du har en buggrapport, en funktionsbeg�ran, eller ett f�rslag, �ppna ett nytt �rende. F�r att skicka in en patch, var v�nlig skapa en PR.