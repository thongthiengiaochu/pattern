namespace Facade
{
    public class AccountChecker
    {
        private string accountName;

        public AccountChecker(string accountName)
        {
            this.accountName = accountName;
        }

        public bool isValid(string accountName)
        {
            return this.accountName == accountName;
        }
    }
}
