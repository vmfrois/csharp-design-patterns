using Design.Patterns.Application.Strategy.Models;

namespace Design.Patterns.Application.Strategy.Services.Interfaces
{
    public interface ITipoImposto
    {
        double Calcular(Orcamento orcamento);
    }
}
