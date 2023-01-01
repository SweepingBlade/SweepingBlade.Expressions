using SweepingBlade.Expressions.Domain.Primitives;
using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Domain.Values;

public sealed class LocationValue : PrimitiveValue<Location>
{
    public LocationValue(Location value)
        : base(value)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        ((IDomainConditionExpressionVisitor)visitor).VisitLocation(Value);
    }

    public override LocationValue Clone()
    {
        return new LocationValue(Value);
    }
}