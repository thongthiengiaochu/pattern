using Facade;

BankAccountFacade bankAccountFacade = new BankAccountFacade("Liem Huynh", 1234);

bankAccountFacade.withdrawCash(900000.00);
Console.WriteLine("\n");

bankAccountFacade.depositCash(1000000.00);
Console.WriteLine("\n");

bankAccountFacade.withdrawCash(900000.00);