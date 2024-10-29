namespace Facade
{
    public class BankAccountFacade
    {
        private readonly string accountName;
        private readonly int securityCode;

        private readonly AccountChecker accountChecker;
        private readonly SecurityCodeChecker securityCodeChecker;
        private readonly CashManager cashManager;

        public BankAccountFacade(string accountName, int securityCode)
        {
            this.accountName = accountName;
            this.securityCode = securityCode;

            accountChecker = new AccountChecker(accountName);
            securityCodeChecker = new SecurityCodeChecker(securityCode);
            cashManager = new CashManager(1000.00);
        }

        public void depositCash(double cashAmount)
        {
            if (accountChecker.isValid(accountName) && securityCodeChecker.isValid(securityCode))
            {
                cashManager.Deposit(cashAmount);

                Console.WriteLine("Complete Deposit Cash");
            }
            else
            {
                Console.WriteLine("!Complete Deposit Cash");
            }
        }

        public void withdrawCash(double cashAmount)
        {
            if (accountChecker.isValid(accountName) && securityCodeChecker.isValid(securityCode)
                && cashManager.HaveEnoughMoney(cashAmount))
            {
                cashManager.Withdraw(cashAmount);

                Console.WriteLine("Complete Withdraw Cash");
            }
            else
            {
                Console.WriteLine("!Complete Withdraw Cash");
            }
        }
    }
}
