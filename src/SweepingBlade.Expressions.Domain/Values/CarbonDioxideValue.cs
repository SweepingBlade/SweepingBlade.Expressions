using SweepingBlade.Expressions.Domain.Primitives;
using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Domain.Values;

public sealed class CarbonDioxideValue : PrimitiveValue<CarbonDioxide>
{
    public CarbonDioxideValue(CarbonDioxide value)
        : base(value)
    {
    }

    public override CarbonDioxideValue Clone()
    {
        return new CarbonDioxideValue(Value);
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        ((IDomainConditionExpressionVisitor)visitor).VisitCarbonDioxide(Value);
    }
}