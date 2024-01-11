using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager employeeManager = new ContractEmployeeManager();    
            _emp.MedicalAllowance = employeeManager.GetMedicalAllowance();

            return employeeManager;
        }
    }
}