using System.Linq.Expressions;
using SweepingBlade.Expressions.Expressions;
using SweepingBlade.Expressions.Symbols;
using SweepingBlade.Expressions.Values;
using BinaryExpression = SweepingBlade.Expressions.Expressions.BinaryExpression;
using ConstantExpression = SweepingBlade.Expressions.Expressions.ConstantExpression;
using DynamicExpression = SweepingBlade.Expressions.Expressions.DynamicExpression;
using Expression = SweepingBlade.Expressions.Expressions.Expression;
using UnaryExpression = SweepingBlade.Expressions.Expressions.UnaryExpression;

namespace SweepingBlade.Expressions;

public abstract class ConditionExpressionVisitor : IConditionExpressionVisitor
{
    public virtual BinaryExpression VisitBinaryExpression(BinaryExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual bool VisitBoolean(bool value)
    {
        return value;
    }

    public virtual BooleanValue VisitBooleanValue(BooleanValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual ComparisonExpression VisitComparisonExpression(ComparisonExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual ComparisonOperator VisitComparisonOperator(ComparisonOperator value)
    {
        return value;
    }

    public virtual ConditionalExpression VisitConditionalExpression(ConditionalExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual ConstantExpression VisitConstantExpression(ConstantExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual DateTime VisitDateTime(DateTime value)
    {
        return value;
    }

    public virtual Expression<Func<object?>> VisitDynamic(Expression<Func<object?>> value)
    {
        return value;
    }

    public virtual DynamicExpression VisitDynamicExpression(DynamicExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual Enum VisitEnum(Enum value)
    {
        return value;
    }

    public virtual IEvaluatable VisitEvaluatable(IEvaluatable value)
    {
        switch (value)
        {
            case ComparisonExpression comparisonExpression:
                VisitComparisonExpression(comparisonExpression);
                break;
            case LogicalExpression logicalExpression:
                VisitLogicalExpression(logicalExpression);
                break;
            case NotExpression notExpression:
                VisitNotExpression(notExpression);
                break;
            case ConstantExpression constantExpression:
                VisitConstantExpression(constantExpression);
                break;
            case DynamicExpression dynamicExpression:
                VisitDynamicExpression(dynamicExpression);
                break;
            case BooleanValue booleanValue:
                VisitBooleanValue(booleanValue);
                break;
            case IntegerValue integerValue:
                VisitIntegerValue(integerValue);
                break;
            case StringValue stringValue:
                VisitStringValue(stringValue);
                break;
            case TimeSpanValue timeSpanValue:
                VisitTimeSpanValue(timeSpanValue);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
        }

        return value;
    }

    public virtual Expression VisitExpression(Expression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual int VisitInteger(int value)
    {
        return value;
    }

    public virtual IntegerValue VisitIntegerValue(IntegerValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual LogicalExpression VisitLogicalExpression(LogicalExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual LogicalOperator VisitLogicalOperator(LogicalOperator value)
    {
        return value;
    }

    public virtual NotExpression VisitNotExpression(NotExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual IPrimitiveValue VisitPrimitiveValue(IPrimitiveValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual string VisitString(string value)
    {
        return value;
    }

    public virtual StringValue VisitStringValue(StringValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual Symbol VisitSymbol(Symbol value)
    {
        value.Accept(this);
        return value;
    }

    public virtual TimeSpan VisitTimeSpan(TimeSpan value)
    {
        return value;
    }

    public virtual TimeSpanValue VisitTimeSpanValue(TimeSpanValue value)
    {
        value.Accept(this);
        return value;
    }

    public virtual UnaryExpression VisitUnaryExpression(UnaryExpression value)
    {
        value.Accept(this);
        return value;
    }

    public virtual Value VisitValue(Value value)
    {
        value.Accept(this);
        return value;
    }
}