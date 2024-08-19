using CalculatorApp.Strategies;

namespace CalculatorApp;

public class Calculator
{
    private IOperation? _operation;
    private readonly Dictionary<string, IOperation> _operations = CalculatorConfig.RegisterOperations();

    public void SetOperation(string operatorSymbol)
    {
        if (_operations.TryGetValue(operatorSymbol, out var operation))
        {
            _operation = operation;
        }
        else
        {
            throw new InvalidOperationException("Invalid operation!");
        }
    }

    public double Calculate(double num1, double num2)
    {
        if (_operation == null)
        {
            throw new InvalidOperationException("Operation must be set!");
        }
        return Math.Round(_operation.Execute(num1, num2), 2);
    }
}