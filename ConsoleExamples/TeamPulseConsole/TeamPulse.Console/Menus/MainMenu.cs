using Spectre.Console;
using TeamPulse.Console.Views;

namespace TeamPulse.Console.Menus;

public class MainMenu : IMainMenu
{
    private readonly IEmployeeView _employeeView;

    public MainMenu(IEmployeeView employeeView)
    {
        _employeeView = employeeView;
    }

    public void Display()
    {
        var exit = false;
        while (!exit)
        {
            AnsiConsole.Clear();
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Select from the menu:")
                .AddChoices("Show All", "Exit")
            );

            switch (selection)
            {
                case "Show All":
                    _employeeView.DisplayAllEmployees();
                    break;
                case "Exit":
                    exit = true;
                    break;
            }
        }
    }
}
