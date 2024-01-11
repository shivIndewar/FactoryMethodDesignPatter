using EmployeePortal.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int EmployeeTypeId)
        {
            IEmployeeManager returnValue = null;

            if (EmployeeTypeId == 1)
                returnValue = new PermanantEmployeeManager();
            else if (EmployeeTypeId == 2)
                returnValue = new ContractEmployeeManager();


            return returnValue;
        }
    }
}