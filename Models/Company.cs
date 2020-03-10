using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {
    public DateTime DateFounded { get; }
    public string CompanyName { get; }
    public List<Employee> ListOfEmployees { get; set; } = new List<Employee>();
    public List<Company> ListOfCompanies { get; set; } = new List<Company>();

    public Company(string companyName, DateTime dateFound)
    {
      CompanyName = companyName;
      DateFounded = DateTime.Now;
    }

    public void ListEmployees()
    {
      Console.WriteLine("These people own Wright Enterprises!");
      Console.WriteLine("====================================");

      foreach (Employee employee in ListOfEmployees)
      {
        Console.WriteLine($" { employee.FirstName } { employee.LastName } is a { employee.Title } at Wright Enterprises as of { employee.StartDate }");
        Console.WriteLine("==================================================================");
      }
    }

    public void ListCompanies()
    {
      foreach (Company business in ListOfCompanies)
      {
        Console.WriteLine($" { business.CompanyName } was founded on { business.DateFounded }");
        Console.WriteLine($"=================================================================");

      }
    }

  }
}