using Spectre.Console;
using TeamPulse.Console.Models;

namespace TeamPulse.Console.Helpers;

public class TableVisualization
{
    public static void DisplayEmployeeTable(List<Employee> employees)
    {
        var table = new Table();
        table.Title = new TableTitle("Employees");
        table.AddColumns("Id", "Name", "Email", "Department");

        foreach (var employee in employees)
        {
            table.AddRow(employee.Id.ToString(), employee.Name, employee.Email, employee.Department);
        }

        AnsiConsole.Write(table);
    }
}
