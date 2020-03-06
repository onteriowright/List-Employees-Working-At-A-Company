using System;
using System.Collections.Generic;

namespace Classes
{
  public class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string StartDate { get; set; }
    public List<Employee> ListOfEmployees = new List<Employee>();

    public void FullName()
    {
      Console.WriteLine($"{FirstName} {LastName}");
    }

    public Employee(string firstName, string lastName, string title, string startDate)
    {
      FirstName = firstName;
      LastName = lastName;
      Title = title;
      StartDate = startDate;
    }

    public void ListEmployees()
    {
      foreach (Employee info in ListOfEmployees)
      {
        Console.WriteLine(info.FirstName);
        Console.WriteLine(info.LastName);
        Console.WriteLine(info.Title);
        Console.WriteLine(info.StartDate);
      }
    }
  }
}