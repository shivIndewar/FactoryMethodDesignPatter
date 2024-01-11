using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbsrtractFactory.Enumerations;

namespace EmployeePortal.Factory.AbsrtractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}