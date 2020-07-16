using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        public string Name { get; }
        public DateTime DateFounded { get; }
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();

        public Company(string nameParam, DateTime dateParam){
            Name = nameParam;
            DateFounded = dateParam;
        }

        public void ListEmployees()
        {
            EmployeeList.ForEach((Employee) =>
            {
                Console.WriteLine($"{Employee.FirstName} {Employee.LastName}");
            });
        }
    }
}