using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebServicesDemo.Models;

namespace WebServicesDemo.Services
{
    class EmployeeServices
    {
        public async Task<List<Employee>> GetEmployeeAsync()

        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            
            var employeesList = await restClient.GetAsync();
            return employeesList;
        }
    }
}
