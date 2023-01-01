using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Expressions;

public abstract class ConstantExpression : Expression
{
    protected ConstantExpression(IPrimitiveValue value)
    {
        RawValue = value;
    }

    public IPrimitiveValue RawValue { get; }
    public abstract override ConstantExpression Clone();

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitPrimitiveValue(RawValue);
    }
}

public sealed class ConstantExpression<T> : ConstantExpression
{
    public ConstantExpression(IPrimitiveValue<T> value)
        : base(value)
    {
        Value = value;
    }

    public IPrimitiveValue<T> Value { get; }

    public override ConstantExpression<T> Clone()
    {
        return new ConstantExpression<T>((IPrimitiveValue<T>)Value.Clone());
    }
}