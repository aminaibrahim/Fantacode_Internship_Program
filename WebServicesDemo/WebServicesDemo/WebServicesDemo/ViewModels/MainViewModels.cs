using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebServicesDemo.Models;
using WebServicesDemo.Services;

namespace WebServicesDemo.ViewModels
{
    public class MainViewModels : INotifyPropertyChanged
    {
        private List<Employee> _EmployeeList { get; set; }
        public List<Employee> EmployeeList
        {
            get
            {
                return _EmployeeList;
            }
            set
            {
                _EmployeeList = value; 
                OnPropertyChanged();
            }
        }

        public  MainViewModels()
        {
            InitialisedataAsync();
        }
        private async Task InitialisedataAsync()
        {
            var employeeServices = new EmployeeServices();
        EmployeeList = await employeeServices.GetEmployeeAsync();

    }


        
         public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
