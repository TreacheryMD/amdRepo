﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class DepositAccount : BankAccount,ITransferRecive
    {
        double _depIntRate;
        public DepositAccount(CurrentAccount curentAcc, decimal balance, double depositInterestRate) :
            base(curentAcc.Client, balance, curentAcc.AccNum.Substring(0, curentAcc.AccNum.Length - 2) + "DEP")
        {
            _depIntRate = depositInterestRate;
        }

        public override void ShowAccountInfo()
        {
            Console.WriteLine("Deposit Account:");
            base.ShowAccountInfo();
        }

        public void CalcDepAftMonths(int numbOfMonths)
        {
            for (int i = 0; i < numbOfMonths; i++)
            {
                this.Balance += (this.Balance * (decimal)this._depIntRate /100)/12;
            }
        }
        public void Recive(decimal ammount)
        { 
            this.Balance += ammount;
        }
    }
}
