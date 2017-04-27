using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeInfo.API.Controllers
{
  [Route("api/employees")]
  public class EmployeesInfoController : Controller
  {
    [HttpGet()]
    public IActionResult GetEmployees()
    {
      return Ok(EmployeesDataStore.Current.Employees);
    }

    [HttpGet("{id}")]
    public IActionResult GetEmployee(int id)
    {
      var employee = EmployeesDataStore.Current.Employees.FirstOrDefault(emp => emp.Id == id);
      if (employee == null)
        return NotFound();
      return Ok(employee);

    }
  }
}
