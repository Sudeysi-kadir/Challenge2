namespace Calculator.Console.Logic;

public class CalculatorLogic
{
    public double Addition(double a, double b)
    {
         return a + b;
    }
    public double Subtraction(double a, double b)
    {
         return a - b;
    }
    public double Multiplication(double a, double b)
    {
        return a * b;
    }
    public double Division(double a, double b)
    {
        if (b == 0)
            return double.NaN;
        return a /b;
    }
}