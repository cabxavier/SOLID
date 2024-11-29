namespace Solid._04_ISP.Good;

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculator
{
    void CalculateBenefits();
}

public class FullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Salary calculated");
    }

    public void CalculateBenefits()
    {
        Console.WriteLine("Benefits calculated");
    }
}

public class ContractEmployee : ISalaryCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Salary calculated");
    }
}