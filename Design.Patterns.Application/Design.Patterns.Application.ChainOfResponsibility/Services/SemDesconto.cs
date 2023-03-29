using Design.Patterns.Application.ChainOfResponsibility.Models;
using Design.Patterns.Application.ChainOfResponsibility.Services.Interfaces;

namespace Design.Patterns.Application.ChainOfResponsibility.Services
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
