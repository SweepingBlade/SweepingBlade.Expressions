namespace SweepingBlade.Expressions.Expressions;

public abstract class UnaryExpression : Expression
{
    protected UnaryExpression(IEvaluatable expression)
    {
        Expression = expression ?? throw new ArgumentNullException(nameof(expression));
    }

    public IEvaluatable Expression { get; }
}