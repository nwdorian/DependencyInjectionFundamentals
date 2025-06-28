using TeamPulse.Console.Models;
using TeamPulse.Console.Repositories;

namespace TeamPulse.Console.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public List<Employee> GetAllEmployees()
    {
        return _employeeRepository.GetAllEmployees();
    }
}
