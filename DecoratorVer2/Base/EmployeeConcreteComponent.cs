namespace DecoratorVer2.Base
{
    public class EmployeeConcreteComponent : IEmployeeComponent
    {
        private readonly string name;

        public EmployeeConcreteComponent(string name)
        {
            this.name = name;
        }

        public string GetName() => name;

        public void Join(DateTime joinDate)
        {
            Console.WriteLine($"{GetName()} joined on {joinDate}");
        }

        public void Terminate(DateTime terminateDate)
        {
            Console.WriteLine($"{GetName()} terminated on {terminateDate}");
        }

        public void DoTask()
        {
            Console.WriteLine($"{GetName()} is performing their job duties.");
        }
    }
}
