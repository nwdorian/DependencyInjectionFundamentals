using TeamPulse.Console.Models;

namespace TeamPulse.Console.Services;

public interface IEmployeeService
{
    List<Employee> GetAllEmployees();
}
