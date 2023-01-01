namespace SweepingBlade.Expressions.Expressions;

public sealed class ComparisonExpression : BinaryExpression<ComparisonOperator>
{
    public ComparisonExpression(IEvaluatable leftOperand, ComparisonOperator @operator, IEvaluatable rightOperand)
        : base(leftOperand, @operator, rightOperand)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitEvaluatable(LeftOperand);
        visitor.VisitComparisonOperator(Operator);
        visitor.VisitEvaluatable(RightOperand);
    }

    public override ComparisonExpression Clone()
    {
        return new ComparisonExpression((IEvaluatable)LeftOperand.Clone(), Operator,
            (IEvaluatable)RightOperand.Clone());
    }
}