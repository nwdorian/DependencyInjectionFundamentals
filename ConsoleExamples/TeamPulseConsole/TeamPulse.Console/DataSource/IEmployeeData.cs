using TeamPulse.Console.Models;

namespace TeamPulse.Console.DataSource;

public interface IEmployeeData
{
    List<Employee> Employees { get; set; }
    List<Employee> GetEmployees();
}
