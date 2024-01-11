using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbsrtractFactory.Enumerations;

namespace EmployeePortal.Factory.AbsrtractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }
    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I3.ToString();
        }
    }
}