using DataStatsMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Models.ViewModels
{
    public class EmployeeViewModel : Employee
    {

        private readonly IDepartmentRepository _departments;
        public List<Department> Departments { get; set; }

        public EmployeeViewModel(IDepartmentRepository deparment)
        {
            _departments = deparment;
            SetDepartments();
        }

        public void SetDepartments()
        {
            Departments = _departments.GetAll().ToList();
        }
    }
}
