﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class HiringStrategyContext : IHiringStrategyContext
    {
        ICompanyStrategy _IcompanyStrategies;

        public HiringStrategyContext(ICompanyStrategy IcompanyStrategies)
        {
            _IcompanyStrategies = IcompanyStrategies;
        }

        public void DefineStrategies()
        {
           
            Console.WriteLine(this._IcompanyStrategies.EmployeeStrategies());
        }
    }
}
