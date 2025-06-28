using TeamPulse.Api.Models;
using TeamPulse.Api.Repositories;

namespace TeamPulse.Api.Services;

public class EmployeeService
{
    // By manually creating an instance of a dependency class means we have tight coupling
    private readonly EmployeeRepository _employeeRepository = new();
    public List<Employee> GetAllEmployees()
    {
        return _employeeRepository.GetAllEmployees();
    }
}
