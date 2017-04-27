using EmployeeInfo.API.Models;
using System.Collections.Generic;

namespace EmployeeInfo.API
{
  public class EmployeesDataStore
  {
    public static EmployeesDataStore Current { get; } = new EmployeesDataStore();
    public List<EmployeeDto> Employees { get; set; }

    public EmployeesDataStore()
    {
      //Dummy data
      Employees = new List<EmployeeDto>()
            {
                new EmployeeDto()
                {
                     Id = 1,
                     Name = "Akhil Mittal",
                     Designation = "Technical Manager",
                     Salary="$50000",
                     CompaniesWorkedWith=new List<NumberOfCompaniesWorkedDto>()
                     {
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=1,
                         Name="Eon Technologies",
                         Description="Financial Technologies"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=2,
                         Name="CyberQ",
                         Description="Outsourcing"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=3,
                         Name="Magic Software Inc",
                         Description="Education Technology and Fin Tech"
                       }
                     }
                },
                new EmployeeDto()
                {
                     Id = 2,
                     Name = "Keanu Reaves",
                     Designation = "Developer",
                     Salary="$20000",
                     CompaniesWorkedWith=new List<NumberOfCompaniesWorkedDto>()
                     {
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=1,
                         Name="Eon Technologies",
                         Description="Financial Technologies"
                       }
                     }
                },
                 new EmployeeDto()
                {
                     Id = 3,
                     Name = "John Travolta",
                     Designation = "Senior Architect",
                     Salary="$70000",
                     CompaniesWorkedWith=new List<NumberOfCompaniesWorkedDto>()
                     {
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=1,
                         Name="Eon Technologies",
                         Description="Financial Technologies"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=2,
                         Name="CyberQ",
                         Description="Outsourcing"
                       }
                     }
                },
                  new EmployeeDto()
                {
                     Id = 4,
                     Name = "Brad Pitt",
                     Designation = "Program Manager",
                     Salary="$80000",
                     CompaniesWorkedWith=new List<NumberOfCompaniesWorkedDto>()
                     {
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=1,
                         Name="Infosys Technologies",
                         Description="Financial Technologies"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=2,
                         Name="Wipro",
                         Description="Outsourcing"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=3,
                         Name="Magic Software Inc",
                         Description="Education Technology and Fin Tech"
                       }
                     }
                },
                   new EmployeeDto()
                {
                     Id = 5,
                     Name = "Jason Statham",
                     Designation = "Delivery Head",
                     Salary="$90000",
                     CompaniesWorkedWith=new List<NumberOfCompaniesWorkedDto>()
                     {
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=1,
                         Name="Fiserv",
                         Description="Financial Technologies"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=2,
                         Name="Wipro",
                         Description="Outsourcing"
                       },
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=3,
                         Name="Magic Software Inc",
                         Description="Education Technology and Fin Tech"
                       }
                       ,
                       new NumberOfCompaniesWorkedDto()
                       {
                         Id=4,
                         Name="Sapient",
                         Description="Education Technology and Fin Tech"
                       }
                     }
                }
            };

    }
  }
}
