using BankCalculator;
using System;

namespace BankCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account { Balance = 1000, Type = "Зарплатный" };
            Account account2 = new Account { Balance = 500, Type = "Обычный" };

            ICalcAccount calcAccount1 = new CalculateOrdinary();
            calcAccount1.CalculateInterest(account1);

            ICalcAccount calcAccount2 = new CalculateSalary();
            calcAccount2.CalculateInterest(account2);


            Console.WriteLine($"Тип аккаунта:{account1.Type}, Баланс:{account1.Balance}, Процентная ставка:{account1.Interest}");

            Console.WriteLine();

            Console.WriteLine($"Тип аккаунта:{account2.Type}, Баланс:{account2.Balance}, Процентная ставка:{account2.Interest}");

            Console.WriteLine();

            ///<summary>
            ///Добавим новый класс CalculateVIP и это расширение функциональности. Модификаций нет.
            ///</summary>
            Account account3 = new Account { Balance = 700, Type = "VIP Клиент" };
            ICalcAccount calcAccount3 = new CalculateVIP();
            calcAccount3.CalculateInterest(account3);

            Console.WriteLine($"Тип аккаунта:{account3.Type}, Баланс:{account3.Balance}, Процентная ставка:{account3.Interest}");

            Console.ReadKey();
        }
    }
}