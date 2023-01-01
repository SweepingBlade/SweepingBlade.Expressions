namespace SweepingBlade.Expressions.Values;

public abstract class PrimitiveValue : Value, IPrimitiveValue
{
    protected PrimitiveValue(object? rawValue)
    {
        RawValue = rawValue;
    }

    public object? RawValue { get; }
    public abstract override PrimitiveValue Clone();
}

public abstract class PrimitiveValue<T> : PrimitiveValue, IPrimitiveValue<T>
{
    protected PrimitiveValue(T value)
        : base(value)
    {
        Value = value;
    }

    public T Value { get; }
    public abstract override PrimitiveValue<T> Clone();
}