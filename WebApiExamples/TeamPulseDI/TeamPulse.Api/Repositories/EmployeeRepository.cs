using TeamPulse.Api.DataSource;
using TeamPulse.Api.Models;

namespace TeamPulse.Api.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    // By injecting the dependency object trough the contructor we achieve loose coupling
    private readonly IEmployeeData _dataSource;
    public EmployeeRepository(IEmployeeData dataSource)
    {
        _dataSource = dataSource;
    }

    // Get all employees from the database
    public List<Employee> GetAllEmployees()
    {
        return _dataSource.Employees;
    }
}
