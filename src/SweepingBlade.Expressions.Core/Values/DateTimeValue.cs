namespace SweepingBlade.Expressions.Values;

public sealed class DateTimeValue : PrimitiveValue<DateTime>
{
    public DateTimeValue(DateTime value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitDateTime(Value);
    }

    public override PrimitiveValue<DateTime> Clone()
    {
        return new DateTimeValue(Value);
    }
}