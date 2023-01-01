namespace SweepingBlade.Expressions.Values;

public sealed class StringValue : PrimitiveValue<string>
{
    public StringValue(string value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitString(Value);
    }

    public override StringValue Clone()
    {
        return new StringValue(Value);
    }
}