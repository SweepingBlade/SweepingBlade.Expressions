namespace SweepingBlade.Expressions.Values;

public interface IPrimitiveValue : IEvaluatable
{
    object? RawValue { get; }
}

public interface IPrimitiveValue<out T> : IPrimitiveValue
{
    T Value { get; }
}