namespace SweepingBlade.Expressions.Expressions;

public abstract class Expression : IEvaluatable
{
    object ICloneable.Clone()
    {
        return Clone();
    }

    public abstract void Accept(IConditionExpressionVisitor visitor);
    public abstract Expression Clone();
}