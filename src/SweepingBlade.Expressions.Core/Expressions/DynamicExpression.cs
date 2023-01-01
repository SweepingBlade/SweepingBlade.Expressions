using System.Linq.Expressions;
using System.Reflection;

namespace SweepingBlade.Expressions.Expressions;

public abstract class DynamicExpression : Expression
{
    protected DynamicExpression(Type entityType, MemberInfo memberInfo, Expression<Func<object?>> value)
    {
        EntityType = entityType ?? throw new ArgumentNullException(nameof(entityType));
        MemberInfo = memberInfo ?? throw new ArgumentNullException(nameof(memberInfo));
        Raw = value;
    }

    public Type EntityType { get; }
    public MemberInfo MemberInfo { get; }
    public Expression<Func<object?>> Raw { get; }
    public abstract override DynamicExpression Clone();

    public override void Accept(IConditionExpressionVisitor visitor)
    {
        if (visitor is null) throw new ArgumentNullException(nameof(visitor));
        visitor.VisitDynamic(Raw);
    }
}

public sealed class DynamicExpression<TEntity, TValue> : DynamicExpression
{
    public DynamicExpression(TEntity entity, Expression<Func<TEntity, TValue?>> value)
        : base(GetEntityType(value), GetMemberInfo(value), () => value.Compile().Invoke(entity))
    {
        Entity = entity;
        Value = value;
    }

    public TEntity Entity { get; }
    public Expression<Func<TEntity, TValue?>> Value { get; }

    public override DynamicExpression<TEntity, TValue> Clone()
    {
        return new DynamicExpression<TEntity, TValue>(Entity, Value);
    }

    private static Type GetEntityType(Expression<Func<TEntity, TValue?>> value)
    {
        var memberInfo = value.GetMemberInfo();
        return memberInfo.DeclaringType!;
    }

    private static MemberInfo GetMemberInfo(Expression<Func<TEntity, TValue?>> value)
    {
        var memberInfo = value.GetMemberInfo();
        return memberInfo;
    }
}