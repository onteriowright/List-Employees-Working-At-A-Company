using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Onterio = new Employee("Onterio", "Wright", "Software Engineer", "November 11, 2019");

            Onterio.ListOfEmployees.Add(Onterio);
            Onterio.ListEmployees();
        }
    }
}