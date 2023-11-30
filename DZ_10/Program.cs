using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountOfBank_1;
using Building;

namespace DZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaveBankAccount saveAccount = new SaveBankAccount(5000);
            Console.WriteLine($"Номер созданного счета - {saveAccount.CreateAccount()}");

            СurrentBankAccount currentAccount = new СurrentBankAccount(5000);
            Console.WriteLine($"Номер созданного счета - {currentAccount.CreateAccount()}");
            currentAccount.showAccounts();
            currentAccount.CloseAccount(1);
            Console.WriteLine("Удалили счет с номером 1");
            currentAccount.showAccounts();
            Console.ReadKey();

            Console.WriteLine("ДЗ 11.1");
            Creator.CreateBuild(5, 5, 20, 5);
            Creator.CreateBuild(3, 4, 10, 2);
            Creator.CreateBuild(50, 10, 20, 1);
            Creator.showBuild();
            Console.ReadKey();

            Console.WriteLine("Упр 12.1");
            BankAccount account_1 = new BankAccount(1000, Account.Текущий);
            BankAccount account_2 = new BankAccount(2000, Account.Текущий);
            if (account_1 != account_2)
            {
                Console.WriteLine("Это разные счета");
            }
            else
            {
                Console.WriteLine("Это одинаковые счета");
            }

            if (account_1 == account_2)
            {
                Console.WriteLine("Это одинаковые счета");
            }
            else
            {
                Console.WriteLine("Это разные счета");
            }

            bool flag = account_1.Equals(account_2);
            if (flag)
            {
                Console.WriteLine("Это одинаковые счета");
            }
            else
            {
                Console.WriteLine("Это разные счета");
            }

            Console.WriteLine(account_1.ToString());
            Console.ReadKey();

            Console.WriteLine("Упр 12.2");
            RationalNumbers numb_1 = new RationalNumbers(1, 2);
            RationalNumbers numb_2 = new RationalNumbers(2, 4);
            Console.WriteLine(numb_1 == numb_2);
            Console.WriteLine(numb_1 > numb_2);
            Console.WriteLine(numb_1 < numb_2);
            Console.WriteLine(numb_1 <= numb_2);
            Console.WriteLine(numb_1 >= numb_2);
            Console.WriteLine((--numb_1).ToString());
            Console.WriteLine((++numb_1).ToString());
            Console.WriteLine(numb_2.ToString());
            Console.ReadKey();

            Console.WriteLine("ДЗ 12.1");
            ComplexNumbers num = new ComplexNumbers(21, 54);
            ComplexNumbers num_1 = new ComplexNumbers(2, -5);

            Console.WriteLine(num.ToString());
            Console.WriteLine(num_1.ToString());
            Console.WriteLine((num + num_1).ToString());
            Console.WriteLine((num - num_1).ToString());
            Console.WriteLine((num * num_1).ToString());
            Console.WriteLine((num == num_1));
            Console.ReadKey();

            Console.WriteLine("ДЗ 12.2");
            ArrayOfBook arrayOfBook = new ArrayOfBook();
            Book book_1 = new Book("author_1", "title_1", "publishing_1");
            Book book_2 = new Book("author_1", "title_2", "publishing_2");
            Book book_3 = new Book("author_2", "title_3", "publishing_2");
            Book book_4 = new Book("author_3", "title_3", "publishing_2");
            Book book_5 = new Book("author_1", "title_1", "publishing_1");
            Book book_6 = new Book("author_3", "title_2", "publishing_3");
            arrayOfBook.AddToList(book_1);
            arrayOfBook.AddToList(book_2);
            arrayOfBook.AddToList(book_3);
            arrayOfBook.AddToList(book_4);
            arrayOfBook.AddToList(book_5);
            arrayOfBook.AddToList(book_6);
            arrayOfBook.ShowList();
            Console.WriteLine();

            arrayOfBook.Sort(Book.SortByTitle);
            arrayOfBook.ShowList();
            Console.WriteLine();
            arrayOfBook.Sort(Book.SortByAuthor);
            arrayOfBook.ShowList();
            Console.WriteLine();
            arrayOfBook.Sort(Book.SortByPublishing);
            arrayOfBook.ShowList();
            Console.ReadKey();


        }
    }
}
