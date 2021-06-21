using EmployeeDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDI.Interfaces
{
   public interface IEmployeeRepository
    {
        EmployeeModel GetEmployee(int Id);
    }
}
