using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class ArrojadoService : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            var chance = new Random().Next(101);
            if (chance >= 20 && chance < 30)
            {
                return conta.Saldo * 0.05;
            }
            else if(chance >= 30 && chance < 50)
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.06;
            }
       
        }
    }
}
