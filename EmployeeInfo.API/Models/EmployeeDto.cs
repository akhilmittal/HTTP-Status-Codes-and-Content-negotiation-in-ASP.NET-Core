using System.Collections.Generic;

namespace EmployeeInfo.API.Models
{
  public class EmployeeDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string Salary { get; set; }
    public int NumberOfCompaniesWorkedWith
    {
      get
      {
        return CompaniesWorkedWith.Count;
      }
    }

    public ICollection<NumberOfCompaniesWorkedDto> CompaniesWorkedWith { get; set; } = new List<NumberOfCompaniesWorkedDto>();

  }
}
