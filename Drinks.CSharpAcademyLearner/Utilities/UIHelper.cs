using Spectre.Console;

namespace Drinks.CSharpAcademyLearner.Utilities
{
    internal class UIHelper
    {
        internal static void WaitForKey()
        {
            AnsiConsole.MarkupLine("\n[grey]Press any key to continue...[/]");
            Console.ReadKey(true);
        }

        internal static void WriteTitle()
        {
            AnsiConsole.Write(new FigletText("Drinks Info") { Color = ConsoleColor.Green, Justification = Justify.Center });
        }
    }
}
