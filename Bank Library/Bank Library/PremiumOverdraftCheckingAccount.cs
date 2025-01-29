using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Library
{
    
    public class PremiumOverdraftCheckingAccount : CheckingAccount
    {
        public decimal CashbackRate { get; private set; }
        public PremiumOverdraftCheckingAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal overdraftLimit, decimal cashbackRate):
            base(accountNumber, accountHolder, initialBalance, overdraftLimit)
        {
            CashbackRate = cashbackRate;
        }
        public void ApplyCashback(decimal purchaseAmount)
        {
            if (purchaseAmount <= 0) throw new ArgumentException("Purcahse amount must be greater than 0");
            var cashback = purchaseAmount * CashbackRate;
            this.Deposit(cashback);

        }
        
    }
    
}
