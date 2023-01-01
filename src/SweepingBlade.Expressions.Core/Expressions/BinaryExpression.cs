namespace SweepingBlade.Expressions.Expressions;

public abstract class BinaryExpression : Expression
{
    protected BinaryExpression(IEvaluatable leftOperand, IEvaluatable rightOperand)
    {
        LeftOperand = leftOperand ?? throw new ArgumentNullException(nameof(leftOperand));
        RightOperand = rightOperand ?? throw new ArgumentNullException(nameof(rightOperand));
    }

    public IEvaluatable LeftOperand { get; }
    public IEvaluatable RightOperand { get; }
}

public abstract class BinaryExpression<TOperator> : BinaryExpression where TOperator : Enum
{
    protected BinaryExpression(IEvaluatable leftOperand, TOperator @operator, IEvaluatable rightOperand)
        : base(leftOperand, rightOperand)
    {
        Operator = @operator ?? throw new ArgumentNullException(nameof(@operator));
    }

    public TOperator Operator { get; }
}