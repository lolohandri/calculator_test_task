namespace CalculatorApp.Strategies.Strategies_impl;

public class Multiplication : IOperation
{
    public double Execute(double num1, double num2)
    {
        return num1 * num2;
    }
}