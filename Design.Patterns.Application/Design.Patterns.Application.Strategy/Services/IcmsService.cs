using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class IcmsService : ITipoImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }
    }
}
