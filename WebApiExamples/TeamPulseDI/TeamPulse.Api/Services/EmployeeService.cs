using TeamPulse.Api.Models;
using TeamPulse.Api.Repositories;

namespace TeamPulse.Api.Services;

public class EmployeeService : IEmployeeService
{
    // By injecting the dependency object trough the contructor we achieve loose coupling
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
