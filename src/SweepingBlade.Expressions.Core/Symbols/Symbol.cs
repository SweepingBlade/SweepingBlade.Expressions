using SweepingBlade.Expressions.Values;

namespace SweepingBlade.Expressions.Symbols;

public abstract class Symbol : Value
{
    public abstract override Symbol Clone();
}