namespace DecoratorVer2.Base
{
    public abstract class EmployeeDecorator : IEmployeeComponent
    {
        protected readonly IEmployeeComponent employee;

        protected EmployeeDecorator(IEmployeeComponent employee)
        {
            this.employee = employee;
        }

        public string GetName() => employee.GetName();

        public void Join(DateTime joinDate) => employee.Join(joinDate);

        public void Terminate(DateTime terminateDate) => employee.Terminate(terminateDate);

        public virtual void DoTask() => employee.DoTask();
    }
}
