using DecoratorVer2.Base;

namespace DecoratorVer2.Decorators
{
    public class TeamMember : EmployeeDecorator
    {
        public TeamMember(IEmployeeComponent employee) : base(employee)
        {
        }

        public void ReportTask()
        {
            Console.WriteLine($"{employee.GetName()} Report Task.");
        }

        public void CoordinateWithOthers()
        {
            Console.WriteLine($"{employee.GetName()} Coordinate With Others.");
        }

        public override void DoTask()
        {
            base.DoTask();
            ReportTask();
            CoordinateWithOthers();
        }
    }
}
