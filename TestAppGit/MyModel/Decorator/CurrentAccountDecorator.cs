﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;

namespace MyModel.Decorator
{
    public class CurrentAccountDecorator : AccountDecorator
    {
        public CurrentAccountDecorator(BankAccount currentAccount) : base(currentAccount)
        {

        }

        public override void Freeze()
        {
            _bankAccount.OutMaxBalance();
            base.Freeze();
            OutMaxBalance();
            Console.WriteLine("All your money has been removed from your account.");
        }
    }
}
