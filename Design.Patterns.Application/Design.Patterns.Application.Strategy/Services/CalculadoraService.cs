using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy.Services
{
    public class CalculadoraService
    {
        public void RealizaCalculo(Orcamento orcamento,ITipoImposto imposto)
        {
            var result = imposto.Calcular(orcamento);
            Console.WriteLine(result);
        }
    }
}
