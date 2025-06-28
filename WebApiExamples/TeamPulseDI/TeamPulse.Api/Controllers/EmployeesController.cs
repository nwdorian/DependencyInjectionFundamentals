using Microsoft.AspNetCore.Mvc;
using TeamPulse.Api.Services;

namespace TeamPulse.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    // By injecting the dependency object trough the contructor we achieve loose coupling
    private readonly IEmployeeService _employeeService;
    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var employees = _employeeService.GetAllEmployees();
        return Ok(employees);
    }
}