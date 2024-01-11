using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbsrtractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;

            if (emp.EmployeeTypeID == 1)
            {
                if (emp.JobDescription.ToLower() == "manager")
                {
                    returnValue = new MacLaptopFactory();
                }
                else 
                {
                    returnValue = new MacFactory();
                }
            }
            else if (emp.EmployeeTypeID == 2) {
                if (emp.JobDescription.ToLower() == "manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }

            return returnValue;
            
        }

    }
}