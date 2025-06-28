using TeamPulse.Api.Models;

namespace TeamPulse.Api.DataSource;

public class EmployeeData
{
    public EmployeeData()
    {
        Employees = GetEmployees();
    }
    public List<Employee> Employees { get; set; }
    public List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John Smith",
                Email = "jsmith@gmail.com",
                Department = "Accounting"
            },
            new Employee
            {
                Id = 2,
                Name = "Jane Taylor",
                Email = "jtaylor@gmail.com",
                Department = "Management"
            },
            new Employee
            {
                Id = 3,
                Name = "Mark Wilson",
                Email = "mwilson@gmail.com",
                Department = "Development"
            }
        };
    }
}
