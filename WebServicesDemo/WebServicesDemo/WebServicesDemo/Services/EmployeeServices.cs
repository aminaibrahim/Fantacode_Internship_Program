using System;
using System.Collections.Generic;
using System.Text;
using WebServicesDemo.Models;

namespace WebServicesDemo.Services
{
    class EmployeeServices
    {
        public List<Employee> GetEmployee()

        {
            var list = new List<Employee>
            {
                new Employee
                {
                   Name = "Anu",
                   Department = "Marketing"
                },
            };
            return list;
        }
    }
}
