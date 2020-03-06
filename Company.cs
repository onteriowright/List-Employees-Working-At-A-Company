using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {
    public DateTime DateFounded { get; set; }
    public string CompanyName { get; set; }
    public List<Employee> ListOfEmployees = new List<Employee>();
  }
}