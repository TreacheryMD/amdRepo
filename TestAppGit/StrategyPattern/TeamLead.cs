﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class TeamLead : ICompanyStrategy
    {
        public string EmployeeStrategies()
        {
            return "Contract for Team Lead";
        }
    }
}
