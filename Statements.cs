namespace Swlang;

public abstract class StatementType
{
    public abstract T Accept<T>(IStatementVisitor<T> visitor);
}

public class ExpressionStatement : StatementType
{
    public ExpressionStatement(ExpressionType expression)
    {
        Expression = expression;
    }

    public ExpressionType Expression { get; init; }

    public override T Accept<T>(IStatementVisitor<T> visitor)
    {
        return visitor.Visit(this);
    }
}

public class PrintStatement : StatementType
{
    public PrintStatement(ExpressionType expression)
    {
        Expression = expression;
    }

    public ExpressionType Expression { get; init; }

    public override T Accept<T>(IStatementVisitor<T> visitor)
    {
        return visitor.Visit(this);
    }
}