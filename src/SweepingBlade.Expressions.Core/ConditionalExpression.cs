using SweepingBlade.Expressions.Expressions;

namespace SweepingBlade.Expressions;

public sealed class ConditionalExpression : IConditionExpressionVisitable
{
    public ConditionalExpression(Expression expression)
    {
        Expression = expression ?? throw new ArgumentNullException(nameof(expression));
    }

    public Expression Expression { get; }

    public void Accept(IConditionExpressionVisitor visitor)
    {
        visitor.VisitExpression(Expression);
    }

    public ConditionalExpression Clone()
    {
        return new ConditionalExpression(Expression.Clone());
    }
}