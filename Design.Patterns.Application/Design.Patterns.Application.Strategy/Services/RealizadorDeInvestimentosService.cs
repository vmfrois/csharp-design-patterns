using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class RealizadorDeInvestimentosService
    {
        public void RealizaInvestimento(ContaBancaria conta,IInvestimento investimento)
        {
           double lucro =  investimento.Calcula(conta);
           conta.Depositar(lucro * 0.75);
            Console.WriteLine(conta.Saldo);
        }
    }
}
