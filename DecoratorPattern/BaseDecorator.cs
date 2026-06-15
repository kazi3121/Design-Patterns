public abstract class BaseDecorator : ICoffee
{
    private readonly ICoffee? _coffee;

    public BaseDecorator(ICoffee coffee) => _coffee = coffee;

    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual decimal GetCost() =>_coffee.GetCost();
}