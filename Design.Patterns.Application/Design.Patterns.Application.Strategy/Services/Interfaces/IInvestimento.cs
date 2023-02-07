using Design.Patterns.Application.Strategy.Models;

namespace Design.Patterns.Application.Strategy.Services.Interfaces
{
    public interface IInvestimento
    {
        double Calcula(ContaBancaria conta);
    }
}
