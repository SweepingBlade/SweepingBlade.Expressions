using SweepingBlade.Expressions.Domain.Primitives;
using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Domain.Values;

public sealed class DistanceValue : PrimitiveValue<Distance>
{
    public DistanceValue(Distance value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        ((IDomainConditionExpressionVisitor)visitor).VisitDistance(Value);
    }

    public override DistanceValue Clone()
    {
        return new DistanceValue(Value);
    }
}