using Design.Patterns.Application.ChainOfResponsibility.Models;
using Design.Patterns.Application.ChainOfResponsibility.Services;

namespace Design.Patterns.Application.ChainOfResponsibility
{
    public class MainChainOfResponsibility
    {
        public void BasicChainOfResponsibility()
        {
            Orcamento orcamento = new Orcamento(1000);
            orcamento.AdicionaItem(new Item("Caneta",500));
            orcamento.AdicionaItem(new Item("Lapis", 500));
            orcamento.AdicionaItem(new Item("Geladeira", 500));
            orcamento.AdicionaItem(new Item("Fogão", 500));
            orcamento.AdicionaItem(new Item("Microondas", 500));
            orcamento.AdicionaItem(new Item("Notebook", 500));


            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
            double desconto = calculadora.Calcula(orcamento);
            Console.WriteLine(desconto);
        }

        public void IntermediaryChainOfResponsibility()
        {

        }

        public void AdvancedChainOfResponsibility()
        {

        }

    }
}
