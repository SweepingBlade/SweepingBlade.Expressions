using SweepingBlade.Expressions.Domain.Primitives;
using SweepingBlade.Expressions.Domain.Values;

namespace SweepingBlade.Expressions.Domain;

public abstract class ConditionalExpressionVisitor : ConditionExpressionVisitor, IDomainConditionExpressionVisitor
{
    public CarbonDioxide VisitCarbonDioxide(CarbonDioxide value)
    {
        return value;
    }

    public CarbonDioxideValue VisitCarbonDioxideValue(CarbonDioxideValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual Distance VisitDistance(Distance value)
    {
        return value;
    }

    public virtual DistanceValue VisitDistanceValue(DistanceValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual Location VisitLocation(Location value)
    {
        return value;
    }

    public virtual LocationValue VisitLocationValue(LocationValue value)
    {
        value.Accept(this);
        return value;
    }
}