using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class ConservadorService : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            return conta.Saldo * 0.08;
        }
    }
}
