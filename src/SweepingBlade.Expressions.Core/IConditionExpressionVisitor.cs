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

public interface IConditionExpressionVisitor
{
    BinaryExpression VisitBinaryExpression(BinaryExpression value);
    bool VisitBoolean(bool value);
    BooleanValue VisitBooleanValue(BooleanValue value);
    ComparisonExpression VisitComparisonExpression(ComparisonExpression value);
    ComparisonOperator VisitComparisonOperator(ComparisonOperator value);
    ConditionalExpression VisitConditionalExpression(ConditionalExpression value);
    ConstantExpression VisitConstantExpression(ConstantExpression value);
    DateTime VisitDateTime(DateTime value);
    Expression<Func<object?>> VisitDynamic(Expression<Func<object?>> value);
    DynamicExpression VisitDynamicExpression(DynamicExpression value);
    Enum VisitEnum(Enum value);
    IEvaluatable VisitEvaluatable(IEvaluatable value);
    Expression VisitExpression(Expression value);
    int VisitInteger(int value);
    IntegerValue VisitIntegerValue(IntegerValue value);
    LogicalExpression VisitLogicalExpression(LogicalExpression value);
    LogicalOperator VisitLogicalOperator(LogicalOperator value);
    NotExpression VisitNotExpression(NotExpression value);
    IPrimitiveValue VisitPrimitiveValue(IPrimitiveValue value);
    string VisitString(string value);
    StringValue VisitStringValue(StringValue value);
    Symbol VisitSymbol(Symbol value);
    TimeSpan VisitTimeSpan(TimeSpan value);
    TimeSpanValue VisitTimeSpanValue(TimeSpanValue value);
    UnaryExpression VisitUnaryExpression(UnaryExpression value);
    Value VisitValue(Value value);
}