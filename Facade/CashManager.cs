namespace Facade
{
    public class CashManager
    {
        private double cashInAccount;

        public CashManager(double cashAmount)
        {
            this.cashInAccount = cashAmount;
        }

        public void Deposit(double cashAmount)
        {
            cashInAccount += cashAmount;

            Console.WriteLine($"Cash in account: {cashInAccount:C}");

        }

        public bool HaveEnoughMoney(double cashAmount) => cashInAccount > cashAmount;

        public void Withdraw(double cashAmount)
        {
            if (HaveEnoughMoney(cashAmount))
            {
                cashInAccount -= cashAmount;
                Console.WriteLine($"Cash in account: {cashInAccount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
