namespace SweepingBlade.Expressions.Values;

public sealed class IntegerValue : PrimitiveValue<int>
{
    public IntegerValue(int value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitInteger(Value);
    }

    public override IntegerValue Clone()
    {
        return new IntegerValue(Value);
    }
}