﻿using MyModel.Accounts;
using MyModel.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Repo;

namespace MyModel
{
    class Program
    {
        public delegate void ShowFunctionDelegate(IEnumerable<BankAccount> yourEnum);
        //private static Func<BankAccount, BankAccount, int> sortasda = (c1, c2) => { return c1.OpenDate.CompareTo(c2.OpenDate); };

        static void Main(string[] args)
        {
            var acc1 = new CurrentAccount("Draganel Ion", 500000, "157632541230", new DateTime(2017, 03, 10), "MDL");
            var acc2 = new CurrentAccount("Ursu Victor", 700000, "157632541231", new DateTime(2017, 02, 20), "EUR");
            var acc3 = new CurrentAccount("Potcovski Dumitru", 1000000, "157632541232", new DateTime(2013, 10, 20), "USD");
            var acc4 = new CurrentAccount("Olaru Daniel", 900000, "157632541233", new DateTime(2015, 11, 14), "EUR");
            var acc5 = new CurrentAccount("Hasdeu Petru ", 400000, "157632541234", new DateTime(2014, 09, 13), "MDL");
            var acc6 = new CurrentAccount("Gavrilita Alexandru", 400500, "157632541235", new DateTime(2017, 07, 05), "MDL");
            var acc7 = new CurrentAccount("Bradu Vladimir", -685000, "157632541236", new DateTime(2011, 11, 04), "USD");
            var acc8 = new CurrentAccount("Rau Viorel", 98500, "157632541237", new DateTime(2012, 05, 09), "MDL");
            var acc9 = new CurrentAccount("Semion Radu", 65000, "157632541238", new DateTime(2016, 06, 21), "USD");
            var acc10 = new CurrentAccount("Popov Ilie", 64800, "157632541239", new DateTime(2015, 04, 22), "MDL");
            var acc11 = new CurrentAccount("Rotaru Vasile", 98700, "157632541240", new DateTime(2014, 02, 24), "EUR");
            var acc12 = new CurrentAccount("Ciobanu Anatol", 354000, "157632541241", new DateTime(2017, 01, 17), "EUR");

            List<BankAccount> allAcc = new List<BankAccount>() { acc1, acc2, acc3, acc4, acc5, acc6, acc7, acc8, acc9, acc10, acc11, acc12 };

            Repository newRep = new Repository();
            newRep.Add(allAcc);
 
            TxtReadWrite.WriteToTxt(newRep.Get());
            var newList = TxtReadWrite.ReadFromTxt();


            #region BankAccountsMoovments


            //Repository newRepo = new Repository();
            //newRepo.Add(JohnCrAcc);
            //newRepo.Add(JohnDpAcc);
            //newRepo.Add(JohnCredAcc);
            //newRepo.Add(JohnInterest);

            //try { JohnCrAcc.CashIn(500000); }
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Console.WriteLine("Initial balance:");
            //JohnCrAcc.ShowAccountInfo();

            //JohnCrAcc.Transfer(JohnDpAcc, 100);

            //try
            //{
            //    Console.WriteLine("Transfer to deposit:");
            //    JohnCrAcc.ShowAccountInfo();
            //    JohnDpAcc.ShowAccountInfo();

            //    Console.WriteLine("Transfer to credit:");
            //    JohnCrAcc.Transfer(JohnCredAcc, 5555);
            //    JohnCrAcc.ShowAccountInfo();
            //    JohnCredAcc.ShowAccountInfo();
            //}
            //catch (AccountIsRestrictedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //            #region testing
            //#if !LIGHT
            //            //custom example
            //            //draganelCRacc.Restricted = true;
            //            try
            //            {
            //                JohnCrAcc.CashOut(500000);
            //            }
            //            catch (AccountIsRestrictedException)
            //            {
            //                Console.WriteLine("This account is restricted");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //#endif
            //            #endregion

            //Console.ReadKey();
            #endregion

            #region Banks
            //Bank victoriaBank = new Bank("Victoria Bank S.A.", "31 august 1981 bl. 141", 3, Bank.Reg.Chisinau);
            //Subsidiary subCalarasi = new Subsidiary("VB Calarasi", "Cuza Voda 31/2", Bank.Reg.Calarasi, null);
            //Subsidiary subCahul = new Subsidiary("VB Cahul", "Alexandru cel Bun 2", Bank.Reg.Cahul, 10);

            //List<Bank> organisation = new List<Bank>();
            //organisation.Add(victoriaBank);
            //organisation.Add(subCalarasi);
            //organisation.Add(subCahul);



            //foreach (var part in organisation)
            //{
            //    part.ShowInfo();
            //}

            //SubsidiaryEqualityComparer comparer = new SubsidiaryEqualityComparer();
            //Console.WriteLine(comparer.Equals(subCalarasi, subCahul));
            //Console.WriteLine(comparer.GetHashCode(subCalarasi));
            #endregion






            Console.ReadLine();


        }
    }
}
