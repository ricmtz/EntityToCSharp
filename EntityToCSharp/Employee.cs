using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityToCSharp
{
    class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Mail { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime StartDate { get; set; }
        public int CompanyId { get; set; }
        public int Status { get; set; }

        public Employee(int id, string firstName, string lastName,
                        string mail, DateTime birthDate, DateTime startDate, 
                        int companyId, int status) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Mail = mail;
            Birthdate = birthDate;
            StartDate = startDate;
            CompanyId = companyId;
            Status = status;
        }

        public void ShowInfo() {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("First Name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Mail: {0}", this.Mail);
            Console.WriteLine("Birthdate: {0}", this.Birthdate);
            Console.WriteLine("Start date: {0}", this.StartDate);
            Console.WriteLine("Company id: {0}", this.CompanyId);
            Console.WriteLine("Status: {0}", this.Status);
            Console.WriteLine("--------------------------------");
        }
    }
}
