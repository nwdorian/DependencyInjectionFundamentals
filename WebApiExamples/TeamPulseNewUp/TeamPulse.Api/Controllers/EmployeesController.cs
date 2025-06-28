using Microsoft.AspNetCore.Mvc;
using TeamPulse.Api.Services;

namespace TeamPulse.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    // By manually creating an instance of a dependency class means we have tight coupling
    private readonly EmployeeService _employeeService = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        var employees = _employeeService.GetAllEmployees();
        return Ok(employees);
    }
}
