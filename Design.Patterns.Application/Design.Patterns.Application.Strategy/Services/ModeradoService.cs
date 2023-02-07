using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class ModeradoService : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            var chance = new Random().Next(101) > 50;
            if (chance)
            {
                return conta.Saldo * 0.0250;
            }
            else
            {
                return conta.Saldo * 0.07;
            }
       
        }
    }
}
