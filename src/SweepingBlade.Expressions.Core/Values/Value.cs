namespace SweepingBlade.Expressions.Values;

public abstract class Value : IEvaluatable
{
    public abstract object Clone();

    public abstract void Accept(IConditionExpressionVisitor visitor);
}