using Design.Patterns.Application.ChainOfResponsibility.Models;
using Design.Patterns.Application.ChainOfResponsibility.Services.Interfaces;

namespace Design.Patterns.Application.ChainOfResponsibility.Services
{
    public class DescontoPorMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get ; set; }

        public double Desconta(Orcamento orcamento)
        {
            // Regra de negocio -> Se o numero de itens do orçamento
            // for mais que 5, desconta 10%
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.10;
            }

            // Usamos a Propriedade Proximo, que é a Interface IDesconto
            // Para chamar o ChainOfResposibily, sendo assim vai chamar o proximo desconto
            // Mas como é uma interface, ela nao sabe qual irá puxar
            return Proximo.Desconta(orcamento);
        }
    }
}
