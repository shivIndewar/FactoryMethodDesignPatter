﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Managers
{
    public class PermanantEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }

        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}