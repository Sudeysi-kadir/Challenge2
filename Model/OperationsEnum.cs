namespace Calculator.Console.Model;

public enum Operation
{
    Add,
    Subtraction,
    Multiplication,
    Division
}
public static class OperationToString
{
    public static string OperationConverter(Operation op)
    {
        return op switch
        {
            Operation.Add => "+",
            Operation.Subtraction => "-",
            Operation.Multiplication => "*",
            Operation.Division => "/",
            _ => "Unknown"

        };
    }
}
