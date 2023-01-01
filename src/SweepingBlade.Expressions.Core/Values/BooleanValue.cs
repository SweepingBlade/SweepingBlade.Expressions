namespace SweepingBlade.Expressions.Values;

public sealed class BooleanValue : PrimitiveValue<bool>
{
    public BooleanValue(bool value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitBoolean(Value);
    }

    public override BooleanValue Clone()
    {
        return new BooleanValue(Value);
    }
}