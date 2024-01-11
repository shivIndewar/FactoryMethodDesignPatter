﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }

        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}