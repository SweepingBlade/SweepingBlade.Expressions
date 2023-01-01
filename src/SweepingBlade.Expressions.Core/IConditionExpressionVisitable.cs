namespace SweepingBlade.Expressions;

public interface IConditionExpressionVisitable
{
    void Accept(IConditionExpressionVisitor visitor);
}