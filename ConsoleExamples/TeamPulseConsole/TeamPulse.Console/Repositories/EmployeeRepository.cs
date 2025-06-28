using TeamPulse.Console.DataSource;
using TeamPulse.Console.Models;

namespace TeamPulse.Console.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
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
