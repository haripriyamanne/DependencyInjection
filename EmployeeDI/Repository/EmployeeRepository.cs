using EmployeeDI.Interfaces;
using EmployeeDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDI.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
     
            private List<EmployeeModel> _employeeList;

            public EmployeeRepository()
            {
                _employeeList = new List<EmployeeModel>()
        {
            new EmployeeModel() { Id = 1, Name = "Hari", Department = "HR", Email = "haripriyamanne4@gmail.com" },
            new EmployeeModel() { Id = 2, Name = "Priya", Department = "IT", Email = "priya@gmail.com" },
            new EmployeeModel() { Id = 3, Name = "Latha", Department = "IT", Email = "lathasri@gmail.com" },
        };
            }

        public EmployeeModel GetEmployee(int Id)
            {
                return this._employeeList.FirstOrDefault(e => e.Id == Id);
            }
        }
    }

