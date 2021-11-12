using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndDelegates
{
    public class BankingBonusCalculation : ICalculateDepositBonuses
    {
        public decimal CalculateAmortizedWeeklyBonusForBankAccounts(decimal rate, decimal x, int days)
        {
            // a whole bunch of that dorky stuff that I will never understand and I trust eric to do it.

            return 42;
        }

        decimal ICalculateDepositBonuses.GetBonusForDepositOn(decimal balance, decimal amountOfDeposit)
        {
            return CalculateAmortizedWeeklyBonusForBankAccounts(amountOfDeposit, 1, 1) * 3.8M;
        }
    }
}
