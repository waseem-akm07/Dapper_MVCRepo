using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.ViewModel;

namespace BusinessAcessLayer.Repo
{
    public interface IBusinessLayer
    {
        IEnumerable<EmployeeModel> GetEmployees();
        IEnumerable<EmployeeModel> GetEmployeeById(int id);
    }
}
