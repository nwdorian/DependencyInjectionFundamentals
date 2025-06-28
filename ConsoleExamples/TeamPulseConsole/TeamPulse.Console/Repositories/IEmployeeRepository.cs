using TeamPulse.Console.Models;

namespace TeamPulse.Console.Repositories;

public interface IEmployeeRepository
{
    List<Employee> GetAllEmployees();
}
