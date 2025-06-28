using TeamPulse.Api.Models;

namespace TeamPulse.Api.Repositories;

public interface IEmployeeRepository
{
    List<Employee> GetAllEmployees();
}
