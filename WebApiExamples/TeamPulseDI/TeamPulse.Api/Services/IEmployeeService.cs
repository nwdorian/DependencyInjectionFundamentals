using TeamPulse.Api.Models;

namespace TeamPulse.Api.Services;

public interface IEmployeeService
{
    List<Employee> GetAllEmployees();
}
