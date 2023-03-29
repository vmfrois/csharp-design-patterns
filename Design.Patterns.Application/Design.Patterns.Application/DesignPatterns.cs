using Design.Patterns.Application.ChainOfResponsibility;
using Design.Patterns.Application.Strategy;

namespace Design.Patterns.Application
{
    public class DesignPatterns
    {
        public string PatternName { get; private set; }
        public DesignPatterns(string patternName)
        {
            this.PatternName = patternName;
        }

        public void ExecuteStrategy(string nivel)
        {
            MainStrategy main = new MainStrategy();
            if (nivel == "Iniciante")
            {
                main.BasicStrategy();
            }
            else if (nivel == "Intermediário")
            {
                main.IntermediaryStrategy();
            }
            else
            {
                main.AdvancedStrategy();
            }
        }

        public void ExecuteChainOfResponsibility(string nivel)
        {
            MainChainOfResponsibility main = new MainChainOfResponsibility();
            if (nivel == "Iniciante")
            {
                main.BasicChainOfResponsibility();
            }
            else if (nivel == "Intermediário")
            {
                main.IntermediaryChainOfResponsibility();
            }
            else
            {
                main.AdvancedChainOfResponsibility();
            }
        }


    }
}
