using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Griffology = new Company("Griffology", DateTime.Now);

            Employee Ashon = new Employee{
                FirstName = "Ashon",
                LastName = "Woodbury",
                Title = "CEO",
                StartDate = DateTime.Now
                
            };

              Employee Mike = new Employee{
                FirstName = "Mike",
                LastName = "Unknown",
                Title = "CTO",
                StartDate = DateTime.Now
                
            };

              Employee Lindsey = new Employee{
                FirstName = "Lindsey",
                LastName = "Crittenden",
                Title = "COO",
                StartDate = DateTime.Now
            };

            Griffology.EmployeeList.Add(Ashon);
            Griffology.EmployeeList.Add(Mike);
            Griffology.EmployeeList.Add(Lindsey);

            Griffology.ListEmployees();
            
        }
    }
}
