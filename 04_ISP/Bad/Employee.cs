namespace Solid._04_ISP.Bad;

public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits();
}

public class FullTimeEmployee : IEmployee
{
    public string Name { get; set; }
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Contract benefits");
    }
}

public class ContractorEmployee : IEmployee
{
    public string Name { get; set; }
    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary");
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}