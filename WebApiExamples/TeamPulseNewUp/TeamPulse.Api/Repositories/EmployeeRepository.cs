using TeamPulse.Api.DataSource;
using TeamPulse.Api.Models;

namespace TeamPulse.Api.Repositories;

public class EmployeeRepository
{
    // By manually creating an instance of a dependency class means we have tight coupling
    private readonly EmployeeData _dataSource = new();
    // Get all employees from the database
    public List<Employee> GetAllEmployees()
    {
        return _dataSource.Employees;
    }
}
