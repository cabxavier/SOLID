namespace Solid._02_OCP.Bad;

public enum EProductType
{
    Electronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4
}

public class Discount
{
    public decimal Calculate(EProductType type, decimal price)
    {
        if (type == EProductType.Electronics)
            return price * 0.02m;
        
        if(type == EProductType.Health)
            return price * 0.03m;
        
        if(type == EProductType.Beauty)
            return price * 0.04m;
        
        if(type == EProductType.Fashion)
            return price * 0.05m;

        return price;
    }
}