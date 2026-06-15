public class MilkDecorator : BaseDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + " +  Mlilk";

    }
    public override decimal GetCost()
    {
        return base.GetCost()+ 10.54m;
    }
}