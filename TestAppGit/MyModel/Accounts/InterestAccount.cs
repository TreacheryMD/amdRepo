﻿using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Accounts
{
    class InterestAccount : BankAccount, ITransferRecive
    {
        double _intRate;
        decimal _mPay;
        public InterestAccount(CurrentAccount curentAcc, decimal balance, double interestRate, decimal monthlyPaymant, DateTime openDate, string currency) :
        base(curentAcc.Client, balance, curentAcc.AccNum.Substring(0, curentAcc.AccNum.Length - 2) + "INT", openDate, currency)
        {
            _intRate = interestRate;
            _mPay = monthlyPaymant;
        }

        public override void ShowAccountInfo()
        {
            
            base.ShowAccountInfo();
            Console.WriteLine();
        }

        //public void CalculateRateAfterMonths(int numberOfMonths, CreditAccount credAccBal, CurrentAccount curAccBal)
        //{
        //    if (this.AccNum.Substring(0, AccNum.Length - 3) == credAccBal.AccNum.Substring(0, credAccBal.AccNum.Length - 4)
        //        && (this.AccNum.Substring(0, AccNum.Length - 3) == curAccBal.AccNum.Substring(0, curAccBal.AccNum.Length - 2)))
        //    {
        //        for (int i = 0; i < numberOfMonths; i++)
        //        {
        //            this.Balance = credAccBal.Balance * (decimal)_intRate / 12;
        //            credAccBal.OutBalance(_mPay);
        //            curAccBal.OutBalance(_mPay);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong CreditAccount! This owener doesn't have Credit");
        //    }
        //}

        public void Recive(decimal ammount)
        {
            this.InBalance(ammount);
        }

        public override string ToString()
        {
            return base.ToString() + $" | Interest Rate:{_intRate} | MonthlyPay: {_mPay}";
        }
    }
}
