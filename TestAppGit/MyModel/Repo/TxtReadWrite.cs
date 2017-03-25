﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;
using MyModel.Interfaces;
using MyModel.BAFactory;

namespace MyModel.Repo
{
    class TxtReadWrite
    {
        public  static void WriteToTxt(List<BankAccount> list)
        {
            using (StreamWriter writer = new StreamWriter(Path.GetFullPath(@"Storage\storage.txt")))
            {
                foreach (BankAccount account in list)
                {
                    writer.WriteLine(account + $";{account.GetType().ToString().Split('.').Last()}");
                }
            }
        }
        public static List<BankAccount> ReadFromTxt()
        {
            List<BankAccount> list = new List<BankAccount>();

            using (StreamReader reader = new StreamReader(Path.GetFullPath(@"Storage\storage.txt")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var type = line.Split(';').Last();
                    GenericCreatorBA factory = new GenericCreatorBA();
                    try{list.Add(factory.CreateBankAccount(type, line));}
                    catch (Exception) { throw new Exception("There is no type, something gone wrong"); }
                }
            }
            return list;
        }
    }
}
