using BankCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankCalculator
{
    interface ICalcAccount
    {
        void CalculateInterest(Account account);
    }
}