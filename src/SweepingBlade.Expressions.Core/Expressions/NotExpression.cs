namespace SweepingBlade.Expressions.Expressions;

public sealed class NotExpression : UnaryExpression
{
    public NotExpression(IEvaluatable expression)
        : base(expression)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitEvaluatable(Expression);
    }

    public override NotExpression Clone()
    {
        return new NotExpression(Expression);
    }
}