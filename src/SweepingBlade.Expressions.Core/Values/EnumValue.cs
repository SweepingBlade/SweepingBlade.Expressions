namespace SweepingBlade.Expressions.Values;

public abstract class EnumValue : PrimitiveValue
{
    protected EnumValue(object? rawValue)
        : base(rawValue)
    {
    }

    public abstract override EnumValue Clone();
}

public sealed class EnumValue<T> : EnumValue, IPrimitiveValue<T>
    where T : Enum
{
    public EnumValue(T value)
        : base(value)
    {
        Value = value;
    }

    public T Value { get; }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitEnum(Value);
    }

    public override EnumValue<T> Clone()
    {
        return new EnumValue<T>(Value);
    }
}