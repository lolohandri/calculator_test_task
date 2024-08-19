using CalculatorApp.Strategies;
using CalculatorApp.Strategies.Strategies_impl;

namespace CalculatorApp;

public static class CalculatorConfig
{
    public static Dictionary<string, IOperation> RegisterOperations()
    {
        return new Dictionary<string, IOperation>
        {
            { "+", new Addition() },
            { "-", new Subtraction() },
            { "*", new Multiplication() },
            { "/", new Division() }
        };
    }
}