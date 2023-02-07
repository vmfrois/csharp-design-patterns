using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class IcccService : ITipoImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.05;

            }else if(orcamento.Valor >= 1000.0 && orcamento.Valor <= 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30.0;
            }
        }
    }
}
