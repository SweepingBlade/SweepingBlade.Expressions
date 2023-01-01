using System.Globalization;
using System.Text;
using SweepingBlade.Expressions.Expressions;

namespace SweepingBlade.Expressions.Domain;

public sealed class BookingRateConditionExpressionVisitor : ConditionalExpressionVisitor
{
    private readonly StringBuilder _stringBuilder;

    public BookingRateConditionExpressionVisitor()
    {
        _stringBuilder = new StringBuilder();
    }

    public override bool VisitBoolean(bool value)
    {
        _stringBuilder.Append(value);
        return base.VisitBoolean(value);
    }

    public override ComparisonExpression VisitComparisonExpression(ComparisonExpression value)
    {
        _stringBuilder.Append('(');
        var result = base.VisitComparisonExpression(value);
        _stringBuilder.Append(')');
        return result;
    }

    public override ComparisonOperator VisitComparisonOperator(ComparisonOperator value)
    {
        switch (value)
        {
            case ComparisonOperator.LessThan:
                _stringBuilder.Append(" < ");
                break;
            case ComparisonOperator.GreaterThan:
                _stringBuilder.Append(" > ");
                break;
            case ComparisonOperator.LessThanOrEqualTo:
                _stringBuilder.Append(" <= ");
                break;
            case ComparisonOperator.GreaterThanOrEqualTo:
                _stringBuilder.Append(" >= ");
                break;
            case ComparisonOperator.EqualTo:
                _stringBuilder.Append(" = ");
                break;
            case ComparisonOperator.NotEqual:
                _stringBuilder.Append(" <> ");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
        }

        return base.VisitComparisonOperator(value);
    }

    public override ConstantExpression VisitConstantExpression(ConstantExpression value)
    {
        _stringBuilder.Append('[');
        var result = base.VisitConstantExpression(value);
        _stringBuilder.Append(']');
        return result;
    }

    public override DateTime VisitDateTime(DateTime value)
    {
        _stringBuilder.Append(value.ToString("o", CultureInfo.InvariantCulture));
        return base.VisitDateTime(value);
    }

    public override DynamicExpression VisitDynamicExpression(DynamicExpression value)
    {
        _stringBuilder.Append('{');
        _stringBuilder.Append($"{value.EntityType.Name}->{value.MemberInfo.Name}");
        var result = base.VisitDynamicExpression(value);
        _stringBuilder.Append('}');
        return result;
    }

    public override Enum VisitEnum(Enum value)
    {
        _stringBuilder.Append($"{value.GetType().Name}::{value}");
        return base.VisitEnum(value);
    }

    public override int VisitInteger(int value)
    {
        _stringBuilder.Append(value);
        return base.VisitInteger(value);
    }

    public override LogicalExpression VisitLogicalExpression(LogicalExpression value)
    {
        _stringBuilder.Append('(');
        var result = base.VisitLogicalExpression(value);
        _stringBuilder.Append(')');
        return result;
    }

    public override LogicalOperator VisitLogicalOperator(LogicalOperator value)
    {
        switch (value)
        {
            case LogicalOperator.And:
                _stringBuilder.Append(" AND ");
                break;
            case LogicalOperator.Or:
                _stringBuilder.Append(" OR ");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
        }

        return base.VisitLogicalOperator(value);
    }

    public override NotExpression VisitNotExpression(NotExpression value)
    {
        _stringBuilder.Append("NOT (");
        var result = base.VisitNotExpression(value);
        _stringBuilder.Append(')');
        return result;
    }

    public override string VisitString(string value)
    {
        _stringBuilder.Append('"');
        _stringBuilder.Append(value);
        _stringBuilder.Append('"');
        return base.VisitString(value);
    }

    public string GenerateExpression(ConditionalExpression expression)
    {
        VisitConditionalExpression(expression);
        return _stringBuilder.ToString();
    }
}