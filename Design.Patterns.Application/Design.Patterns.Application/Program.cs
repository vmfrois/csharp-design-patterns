using Design.Patterns.Application.ChainOfResponsibility;
using Design.Patterns.Application.Strategy;

namespace Design.Patterns.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Implement basic Strategy
            Console.WriteLine("----------------------  basic Strategy ----------------------  ");
            MainStrategy strategy = new();
            strategy.BasicStrategyImposto();
            strategy.BasicStrategyInvestimento();
            Console.WriteLine("------------------------------------------------------------  ");
            #endregion

            #region Implement basic Chain Of Responsibility
            MainChainOfResponsibility chainOfResponsibility = new();
            chainOfResponsibility.BasicChainOfResponsibility();
            #endregion

        }
    }
}