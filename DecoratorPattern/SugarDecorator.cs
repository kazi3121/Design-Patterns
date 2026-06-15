public class SugarDecorator : BaseDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => base.GetDescription() + ", Sugar";

    public override decimal GetCost() => base.GetCost() + 5.25m;
}