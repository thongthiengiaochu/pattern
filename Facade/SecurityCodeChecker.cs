namespace Facade
{
    public class SecurityCodeChecker
    {
        private readonly int securityCode;

        public SecurityCodeChecker(int secCode)
        {
            securityCode = secCode;
        }

        public bool isValid(int secCode) => securityCode == secCode;
    }
}
