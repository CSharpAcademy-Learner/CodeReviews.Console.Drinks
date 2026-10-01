using Drinks.CSharpAcademyLearner.Services;
using Drinks.CSharpAcademyLearner.UI;
using Spectre.Console;

try
{
    using var client = new HttpClient();

    var apiService = new ApiService(client);

    var userInterface = new UserInterface(apiService);
    await userInterface.MainMenu();
}
catch (Exception ex)
{
    AnsiConsole.MarkupLine("[bold red]An initialization error occurred:[/]");
    AnsiConsole.WriteException(ex);
    AnsiConsole.MarkupLine("[grey]Press any key to exit...[/]");
    Console.ReadKey();
}