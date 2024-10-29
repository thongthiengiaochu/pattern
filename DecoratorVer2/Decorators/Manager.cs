using DecoratorVer2.Base;

namespace DecoratorVer2.Decorators
{
    public class Manager : EmployeeDecorator
    {
        public Manager(IEmployeeComponent employee) : base(employee)
        {
        }

        public void CreateRequirement()
        {
            Console.WriteLine($"{employee.GetName()} Create Requirement.");
        }

        public void AssignTask()
        {
            Console.WriteLine($"{employee.GetName()} Assign Task.");
        }

        public void ManageProgress()
        {
            Console.WriteLine($"{employee.GetName()} Manage Progress.");
        }

        public override void DoTask()
        {
            base.DoTask();
            CreateRequirement();
            AssignTask();
            ManageProgress();
        }
    }
}
