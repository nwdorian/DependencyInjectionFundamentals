using Spectre.Console;
using TeamPulse.Console.Helpers;
using TeamPulse.Console.Services;

namespace TeamPulse.Console.Views;

public class EmployeeView : IEmployeeView
{
    private readonly IEmployeeService _employeeService;

    public EmployeeView(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public void DisplayAllEmployees()
    {
        var employees = _employeeService.GetAllEmployees();

        if (employees.Count == 0)
        {
            AnsiConsole.MarkupLine("[red]No employees found in the database![/]");
            AnsiConsole.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
            return;
        }

        TableVisualization.DisplayEmployeeTable(employees);
        AnsiConsole.WriteLine("Press any key to continue...");
        System.Console.ReadLine();
    }
}
