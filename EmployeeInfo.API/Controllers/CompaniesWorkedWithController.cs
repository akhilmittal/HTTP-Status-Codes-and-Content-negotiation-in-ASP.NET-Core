using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeInfo.API.Controllers
{
  [Route("api/employees")]
  public class CompaniesWorkedWithController : Controller
  {
    [HttpGet("{employeeid}/companiesworkedwith")]
    public IActionResult GetCompaniesWorkedWith(int employeeId)
    {
      var employee = EmployeesDataStore.Current.Employees.FirstOrDefault(emp => emp.Id == employeeId);
      if (employee == null) return NotFound();
      return Ok(employee.CompaniesWorkedWith);
    }

    [HttpGet("{employeeid}/companyworkedwith/{id}")]
    public IActionResult GetCompanyWorkedWith(int employeeId, int Id)
    {
      var employee = EmployeesDataStore.Current.Employees.FirstOrDefault(emp => emp.Id == employeeId);
      if (employee == null) return NotFound();

      var companyWorkedWith = employee.CompaniesWorkedWith.FirstOrDefault(comp => comp.Id == Id);
      if (companyWorkedWith == null) return NotFound();
      return Ok(companyWorkedWith);
    }
  }
}
