using System.Linq.Expressions;
using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Symbols;

public abstract class DynamicSymbol<TSymbol, TEntity, TPrimitive, TValue> : Symbol
    where TSymbol : DynamicSymbol<TSymbol, TEntity, TPrimitive, TValue>
    where TEntity : class
    where TPrimitive : IPrimitiveValue<TValue>
{
    protected DynamicSymbol(Expression<Func<TEntity, TValue>> value)
    {
        Value = value;
    }

    public Expression<Func<TEntity, TValue>> Value { get; }
    public abstract override void Accept(IConditionExpressionVisitor visitor);

    public abstract override TSymbol Clone();
}