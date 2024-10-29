using DecoratorVer2.Base;
using DecoratorVer2.Decorators;

Console.WriteLine("NORMAL EMPLOYEE:");
IEmployeeComponent employee = new EmployeeConcreteComponent("Liem Huynh");
employee.ShowBasicInformation();
employee.DoTask();

Console.WriteLine("\nTEAM MEMBER:");
IEmployeeComponent teamMember = new TeamMember(employee);
teamMember.ShowBasicInformation();
teamMember.DoTask();

Console.WriteLine("\nTEAM LEADER:");
IEmployeeComponent teamLeader = new TeamLeader(employee);
teamLeader.ShowBasicInformation();
teamLeader.DoTask();

Console.WriteLine("\nMANAGER:");
IEmployeeComponent manager = new Manager(employee);
manager.ShowBasicInformation();
manager.DoTask();

Console.WriteLine("\nTEAM LEADER AND MEMBER:");
IEmployeeComponent teamLeaderAndMember = new TeamLeader(teamMember);
teamLeaderAndMember.ShowBasicInformation();
teamLeaderAndMember.DoTask();

Console.WriteLine("\nTEAM LEADER AND MANAGER:");
IEmployeeComponent teamLeaderAndManager = new Manager(teamLeader);
teamLeaderAndManager.ShowBasicInformation();
teamLeaderAndManager.DoTask();

Console.WriteLine("\nTEAM LEADER AND MANAGER AND MEMBER:");
IEmployeeComponent teamLeaderAndManagerAndMember = new Manager(teamLeaderAndMember);
teamLeaderAndManagerAndMember.ShowBasicInformation();
teamLeaderAndManagerAndMember.DoTask();