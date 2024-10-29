namespace DecoratorVer2.Base
{
    public interface IEmployeeComponent
    {
        string GetName();
        void DoTask();
        void Join(DateTime joinDate);
        void Terminate(DateTime terminateDate);

        void ShowBasicInformation()
        {
            Console.WriteLine("-------");
            Console.WriteLine($"The basic information of {GetName()}");

            Join(DateTime.Now);

            var terminateDate = DateTime.Now.AddMonths(6);
            Terminate(terminateDate);
        }
    }
}
