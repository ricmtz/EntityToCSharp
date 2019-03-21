using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Ricardo", "Martinez", "email_ricardo@globalhitss.com",new DateTime(1996,02,27), new DateTime(2019,02,27), 1, 1));
            employees.Add(new Employee(2, "Erick", "Perez", "email_erick@globalhitss.com", new DateTime(1990, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(3, "Gabriela", "Catillo", "email_gaby@globalhitss.com", new DateTime(1998, 02, 23), new DateTime(2019, 02, 27), 1, 1));
            employees.Add(new Employee(4, "Cesar", "Camarena", "email_cesar@globalhitss.com", new DateTime(1989, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(5, "Alejandro", "Gomez", "email_ale@globalhitss.com", new DateTime(1989, 02, 23), new DateTime(2019, 02, 27), 1, 1));
            employees.Add(new Employee(6, "Esmeralda", "Castillo", "email_esmeralda@globalhitss.com", new DateTime(1996, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(7, "Luis", "Perez", "email_luis@globalhitss.com", new DateTime(1996, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(8, "Xavier", "Perez", "email_xavi@globalhitss.com", new DateTime(1997, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(9, "Sabino", "Gonzalez", "email_sabino@globalhitss.com", new DateTime(1978, 02, 23), new DateTime(2019, 02, 27), 1, 1));
            employees.Add(new Employee(10, "Sebastian", "Parra", "email_sebastian@globalhitss.com", new DateTime(1988, 02, 23), new DateTime(2019, 02, 27), 2, 1));
            employees.Add(new Employee(11, "Jorge", "Gomez", "email_Jorge@globalhitss.com", new DateTime(1990, 02, 23), new DateTime(2019, 02, 27), 1, 1));

            /*
            foreach(Employee e in employees) {
                e.ShowInfo();
            }
            */

            SearchEmployeeByLastName(employees, "Perez");

            Console.ReadKey();
        }

        private static void SearchEmployeeByLastName(List<Employee> employees, String lastName)
        {
            var queryEmployee = from employee in employees
                                   where employee.LastName == lastName
                                   select employee;

            foreach (var emp in queryEmployee)
            {
                emp.ShowInfo();
            }
        }
    }
}
