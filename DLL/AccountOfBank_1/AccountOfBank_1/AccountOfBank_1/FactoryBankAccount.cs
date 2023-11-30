using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOfBank_1
{
    public abstract class FactoryBankAccount
    {
        public static  Hashtable accounts = new Hashtable(9999);
        protected double _balance;
        public abstract int CreateAccount();
        public abstract void CloseAccount(int number);

        public void showAccounts()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts.ContainsKey(i))
                {
                    BankAccount b = accounts[i] as BankAccount;
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}
