using System.Linq.Expressions;
using System.Reflection;

namespace SweepingBlade.Expressions;

public static class ExpressionExtensions
{
    public static MemberInfo GetMemberInfo<TEntity, TMember>(this Expression<Func<TEntity, TMember>> expression)
    {
        return expression.Body switch
        {
            MemberExpression memberExpression => memberExpression.Member,
            MethodCallExpression methodCallExpression => methodCallExpression.Method,
            _ => throw new ArgumentOutOfRangeException(nameof(expression), expression, null)
        };
    }
}