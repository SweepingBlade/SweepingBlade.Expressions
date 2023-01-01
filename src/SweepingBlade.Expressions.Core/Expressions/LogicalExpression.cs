namespace SweepingBlade.Expressions.Expressions;

public sealed class LogicalExpression : BinaryExpression<LogicalOperator>
{
    public LogicalExpression(IEvaluatable leftOperand, LogicalOperator @operator, IEvaluatable rightOperand)
        : base(leftOperand, @operator, rightOperand)
    {
    }

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitEvaluatable(LeftOperand);
        visitor.VisitLogicalOperator(Operator);
        visitor.VisitEvaluatable(RightOperand);
    }

    public override LogicalExpression Clone()
    {
        return new LogicalExpression(LeftOperand, Operator, RightOperand);
    }
}