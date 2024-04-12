namespace KakonDotNetBasicSolution1;

public class DependencyInjections
{
    public DependencyInjections()
    {
        var mainKakon = new MainProgram();
    }
}

public interface IAccount
{
    void PrintDetails();
}

public class CurrentAccount: IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Current Account Details");
    }
}

public class SavingsAccount: IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Savings Account Details");
    }
}

public class Account
{
    private  readonly IAccount _acc;

    public Account(IAccount account)
    {
        _acc = account;
    }

    public void PrintDetails()
    {
        _acc.PrintDetails();
    }
}

public class MainProgram
{
    
    public  MainProgram()
    {
        IAccount ca = new CurrentAccount();
        Account ac = new Account(ca);
        ac.PrintDetails();

        IAccount sa = new SavingsAccount();
        Account ac2 = new Account(sa);
        ac2.PrintDetails();
    }
}

