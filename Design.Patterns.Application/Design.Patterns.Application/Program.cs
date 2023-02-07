using Design.Patterns.Application.Strategy;

namespace Design.Patterns.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainStrategy strategy = new MainStrategy();
            strategy.BasicStrategyImposto();
            strategy.BasicStrategyInvestimento();
        }
    }
}