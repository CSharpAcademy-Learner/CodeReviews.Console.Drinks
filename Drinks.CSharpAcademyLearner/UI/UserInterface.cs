using Drinks.CSharpAcademyLearner.Services;
using Drinks.CSharpAcademyLearner.Utilities;
using Spectre.Console;
using static Drinks.CSharpAcademyLearner.Models.Models;

namespace Drinks.CSharpAcademyLearner.UI
{
    internal class UserInterface
    {
        private readonly ApiService _apiService;

        internal UserInterface(ApiService apiService)
        {
            _apiService = apiService;
        }

        internal async Task MainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                UIHelper.WriteTitle();

                var categories = await AnsiConsole.Status().StartAsync("Fetching Categories...", async ctx => await _apiService.GetCategoriesAsync());

                if (categories == null || categories.Count == 0)
                {
                    AnsiConsole.MarkupLine("[red]Error when fetching categories.[/]");
                    UIHelper.WaitForKey();
                    return;
                }

                categories.Add("Exit app.");

                var selectedCategory = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[bold green]Select a category[/]")
                    .PageSize(30)
                    .AddChoices(categories));

                if (selectedCategory == "Exit app.")
                {
                    break;
                }

                await BrowseDrinksInCategoryAsync(selectedCategory);
            }
        }

        private async Task BrowseDrinksInCategoryAsync(string categoryName)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                UIHelper.WriteTitle();

                var drinks = await AnsiConsole.Status().StartAsync("Fetching drinks...", async ctx => await _apiService.GetDrinksInCategoryAsync(categoryName));

                if (drinks == null || drinks.Count == 0)
                {
                    AnsiConsole.MarkupLine("[red]Error when fetching drinks.[/]");
                    UIHelper.WaitForKey();
                    break;
                }

                drinks.Add(new DrinksInCategory { Name = "Exit." });

                var selectedDrink = AnsiConsole.Prompt(
                    new SelectionPrompt<DrinksInCategory>()
                    .Title("[bold green]Select a drink[/]")
                    .UseConverter(d => d.Name)
                    .PageSize(30)
                    .AddChoices(drinks)
                    );

                if (selectedDrink.Name == "Exit.") { break; }

                await ShowDrinkInfo(selectedDrink.Id);
            }
        }

        private async Task ShowDrinkInfo(string drinkID)
        {
            Console.Clear();
            UIHelper.WriteTitle();

            var drink = await AnsiConsole.Status().StartAsync("Fetching drink info...", async ctx => await _apiService.GetDrinkInfoByIDAsync(drinkID));

            if (drink == null)
            {
                AnsiConsole.MarkupLine("[red]Error when fetching drink info.[/]");
                UIHelper.WaitForKey();
                return;
            }

            var table = new Table().Border(TableBorder.Rounded).Title($"[bold green]{drink.Drink}[/]");
            table.AddColumn("Property");
            table.AddColumn("Value");

            foreach (var prop in drink.GetType().GetProperties())
            {
                var value = prop.GetValue(drink)?.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    table.AddRow(prop.Name, value);
                }
            }

            AnsiConsole.Write(table);

            if (!string.IsNullOrEmpty(drink.DrinkThumb))
            {
                var imageData = await _apiService.GetDrinkThumbnailAsync(drink.DrinkThumb);
                var image = new CanvasImage(imageData).MaxWidth(Math.Min(80, Console.WindowWidth - 4));
                AnsiConsole.Write(image);
                AnsiConsole.WriteLine();
            }

            UIHelper.WaitForKey();
            return;
        }
    }
}
