using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy
{
    public class MainStrategy
    {
        public void BasicStrategy()
        {
            ITipoImposto iss = new IssService();
            ITipoImposto icms = new IcmsService();
            Orcamento orcamento = new Orcamento(500.0);

            CalculadoraService calculadora = new CalculadoraService();
            calculadora.RealizaCalculo(orcamento, iss);
            calculadora.RealizaCalculo(orcamento, icms);
        }
    }
}
