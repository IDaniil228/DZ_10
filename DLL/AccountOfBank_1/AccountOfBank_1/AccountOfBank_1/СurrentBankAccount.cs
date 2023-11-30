using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOfBank_1
{
    public class СurrentBankAccount : FactoryBankAccount
    {
        public СurrentBankAccount(double balance)
        {
            _balance = balance;
        }
        /// <summary>
        /// Создает банковский счет
        /// </summary>
        /// <returns></returns>
        public override int CreateAccount()
        {
            BankAccount currentBankAccount = new BankAccount(_balance, Account.Текущий);
            accounts.Add(currentBankAccount.Number, currentBankAccount);
            return currentBankAccount.Number;
        }
        /// <summary>
        /// Удаляет банковский счет
        /// </summary>
        /// <param name="number"></param>
        public override void CloseAccount(int number)
        {
            accounts.Remove(number);
        }
    }
}
