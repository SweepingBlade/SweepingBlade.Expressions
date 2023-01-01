namespace SweepingBlade.Expressions.Values;

public sealed class TimeSpanValue : PrimitiveValue<TimeSpan>
{
    public TimeSpanValue(TimeSpan value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitTimeSpan(Value);
    }

    public override TimeSpanValue Clone()
    {
        return new TimeSpanValue(Value);
    }
}