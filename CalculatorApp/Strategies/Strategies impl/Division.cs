namespace CalculatorApp.Strategies.Strategies_impl;

public class Division : IOperation
{
    public double Execute(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}