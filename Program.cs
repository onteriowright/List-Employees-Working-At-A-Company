using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Onterio = new Employee("Onterio", "Wright", "Software Engineer", DateTime.Now.ToLocalTime());

            Employee Akemo = new Employee("Akemo", "Wright", "Area Manager", DateTime.Now.ToLocalTime());

            Employee Danyeal = new Employee("Danyeal", "Wright", "Scientist", DateTime.Now.ToLocalTime());

            Company ListAllCompanies = new Company("List All Companies", DateTime.Now.ToLocalTime());

            Company WrightEnterprises = new Company("Wright Enterprises", DateTime.Now.ToLocalTime());
            Company KemosWeldingComplex = new Company("Kemo's Welding Complex", DateTime.Now.ToLocalTime());
            Company DanyealsCreatons = new Company("Danyeal's Creations", DateTime.Now.ToLocalTime());

            WrightEnterprises.ListOfEmployees.Add(Onterio);
            WrightEnterprises.ListOfEmployees.Add(Akemo);
            WrightEnterprises.ListOfEmployees.Add(Danyeal);

            WrightEnterprises.ListEmployees();

            ListAllCompanies.ListOfCompanies.Add(WrightEnterprises);
            ListAllCompanies.ListOfCompanies.Add(KemosWeldingComplex);
            ListAllCompanies.ListOfCompanies.Add(DanyealsCreatons);

            ListAllCompanies.ListCompanies();
        }
    }
}