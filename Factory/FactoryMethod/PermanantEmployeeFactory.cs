using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class PermanantEmployeeFactory : BaseEmployeeFactory
    {
        public PermanantEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanantEmployeeManager manager = new PermanantEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}