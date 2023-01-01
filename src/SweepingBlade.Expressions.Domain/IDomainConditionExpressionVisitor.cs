using SweepingBlade.Expressions.Domain.Primitives;
using SweepingBlade.Expressions.Domain.Values;

namespace SweepingBlade.Expressions.Domain;

public interface IDomainConditionExpressionVisitor : IConditionExpressionVisitor
{
    CarbonDioxide VisitCarbonDioxide(CarbonDioxide value);
    CarbonDioxideValue VisitCarbonDioxideValue(CarbonDioxideValue value);
    Distance VisitDistance(Distance value);
    DistanceValue VisitDistanceValue(DistanceValue value);
    Location VisitLocation(Location value);
    LocationValue VisitLocationValue(LocationValue value);
}