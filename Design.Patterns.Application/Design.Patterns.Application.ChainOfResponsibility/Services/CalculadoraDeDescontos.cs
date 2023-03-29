using Design.Patterns.Application.ChainOfResponsibility.Models;
using Design.Patterns.Application.ChainOfResponsibility.Services.Interfaces;

namespace Design.Patterns.Application.ChainOfResponsibility.Services
{
    public class CalculadoraDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto desconto1 = new DescontoPorMaisDeCincoItens();
            IDesconto desconto2 = new DescontoPorMilReais();
            IDesconto desconto3 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;

            return desconto1.Desconta(orcamento);
        }
    }
}
