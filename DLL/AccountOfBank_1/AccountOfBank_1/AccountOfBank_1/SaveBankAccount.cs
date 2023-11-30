using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOfBank_1
{
    public class SaveBankAccount : FactoryBankAccount
    {
        public SaveBankAccount(double balance)
        {
            _balance = balance;
        }
        /// <summary>
        /// Создает банковский счет
        /// </summary>
        /// <returns></returns>
        public override int CreateAccount()
        {
            BankAccount saveBankAccount = new BankAccount(_balance, Account.Сберегательный);
            accounts.Add(saveBankAccount.Number, saveBankAccount);
            return saveBankAccount.Number;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public override void CloseAccount(int number)
        {
            accounts.Remove(number);
        }
    }
}
