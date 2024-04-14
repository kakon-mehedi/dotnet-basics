namespace KakonDotNetBasicSolution1.Ooops;

public class StudentGetterSetter
{
    private readonly string _name;
    private readonly double _income;
    private double _taxAmount;

    public StudentGetterSetter(string name, double income)
    {
        _name = name;
        _income = income;
    }

    public string FullName
    {

        get
        {
            if (_income > 500)
            {
                return $"{_name} Borolox";
            }
            else
            {
                return $"{_name} Goribs";
            }
        }
    }

    public double TaxAmount
    {
        get => _income > 500 ? 50 : 0;
        set => _taxAmount = value + 10;
    }

    public double TaxValue
    {
        get => _taxAmount;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Tax Amount: {TaxAmount}");
    }


}