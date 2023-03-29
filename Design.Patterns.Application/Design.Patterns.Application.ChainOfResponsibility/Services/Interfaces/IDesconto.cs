using Design.Patterns.Application.ChainOfResponsibility.Models;

namespace Design.Patterns.Application.ChainOfResponsibility.Services.Interfaces
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
