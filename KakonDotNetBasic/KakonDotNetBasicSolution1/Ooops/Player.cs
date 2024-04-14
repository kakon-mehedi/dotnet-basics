using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace KakonDotNetBasicSolution1.Ooops;

public class Player
{
    protected readonly string FullName;
    protected readonly string Occupation;
    protected readonly double Income;

    protected Player(string fullName, string occupation, double income )
    {
        FullName = fullName;
        Occupation = occupation;
        Income = income;

    }

    public void ShowGreetings()
    {
        Console.WriteLine("Hello");
    }
}

public interface IPlayer
{
    public void ShowDetails();
}

public interface IIncome
{
    public void ShowIncome();
}

public class Cricketer : Player, IPlayer, IIncome
{
    private readonly int _centuries;
    
    public Cricketer(string name, string occ, int centuries, double income): base(name, occ, income)
    {
        _centuries = centuries;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{FullName} is a {Occupation} and He has {_centuries}");
    }

    public void ShowIncome()
    {
        Console.WriteLine($"He earns {Income}");
    }
}

// Inheriting Player Class and Implementing IPlayer and IIncome Interfaces in the Footballer class
public class Footballer : Player, IPlayer, IIncome
{
    private readonly int _goals = 120;
        
    public Footballer(string fullName, string occ, int goals, double income): base(fullName, occ, income)
    {
        _goals = goals;
        _goals = 400;
        _goals = 235;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{FullName} is a {Occupation} and He has {_goals}");
    }

    public void ShowIncome()
    {
        Console.WriteLine($"He earns {Income}");
    }

    // Overriding Base class ShowGreetings Method that's why need to add new keyword before the method name
    public new void ShowGreetings()
    {
        Console.WriteLine("Assalamu Alaikum!");
    }
}