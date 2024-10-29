using DecoratorVer2.Base;

namespace DecoratorVer2.Decorators
{
    public class TeamLeader : EmployeeDecorator
    {
        public TeamLeader(IEmployeeComponent employee) : base(employee)
        {
        }

        public void Planing()
        {
            Console.WriteLine($"{employee.GetName()} Planing.");
        }

        public void Motivate()
        {
            Console.WriteLine($"{employee.GetName()} Motivate.");
        }

        public void Monitor()
        {
            Console.WriteLine($"{employee.GetName()} Monitor.");
        }

        public override void DoTask()
        {
            base.DoTask();
            Planing();
            Motivate();
            Monitor();
        }
    }
}
