using TeamPulse.Api.Models;

namespace TeamPulse.Api.DataSource;

public interface IEmployeeData
{
    List<Employee> Employees { get; set; }
    List<Employee> GetEmployees();
}
